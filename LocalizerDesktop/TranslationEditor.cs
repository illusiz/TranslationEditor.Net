using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security;
using System.Windows.Forms;

namespace LocalizerDesktop
{
    public partial class DataGridForm : Form
    {
        private ColorScheme CurrentColorScheme;

        private List<RowCellIndex> searchList;

        private int searchListIndex = -1;

        public DataGridForm()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
            Draw();
        }

        private void Draw()
        {
            CurrentColorScheme = Utils.GetCurrentColorScheme();

            var colorArray = CurrentColorScheme.FormMainColor.GetRgbFromString();
            BackColor = Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);

            colorArray = CurrentColorScheme.LabelBackColor.GetRgbFromString();
            var colorArray1 = CurrentColorScheme.LabelTextColor.GetRgbFromString();
            var lbls = Controls.OfType<Label>().ToList();
            foreach (var label in lbls)
                if ((label.Tag?.ToString() ?? string.Empty) != "Menu")
                {
                    label.BackColor = Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);
                    label.ForeColor = Color.FromArgb(colorArray1[0], colorArray1[1], colorArray1[2]);
                }
                else
                {
                    var colotArrayForLabel = CurrentColorScheme.FormMenuBackColor.GetRgbFromString();
                    label.BackColor = Color.FromArgb(colotArrayForLabel[0], colotArrayForLabel[1],
                        colotArrayForLabel[2]);
                }

            colorArray = CurrentColorScheme.FormMenuBackColor.GetRgbFromString();
            colorArray1 = CurrentColorScheme.FormMenuTextColor.GetRgbFromString();
            menuStrip1.BackColor = Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);
            menuStrip1.ForeColor = Color.FromArgb(colorArray1[0], colorArray1[1], colorArray1[2]);

            colorArray = CurrentColorScheme.FormMenuBackColor.GetRgbFromString();
            foreach (ToolStripMenuItem menuItem in menuStrip1.Controls)
                menuItem.BackColor = Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);

            colorArray = CurrentColorScheme.ButtonsBackColor.GetRgbFromString();
            colorArray1 = CurrentColorScheme.ButtonsTextColor.GetRgbFromString();
            var btns = Controls.OfType<Button>().ToList();
            foreach (var button in btns)
            {
                button.BackColor = Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);
                button.ForeColor = Color.FromArgb(colorArray1[0], colorArray1[1], colorArray1[2]);
                if ((button.Tag?.ToString() ?? string.Empty) == "Save")
                {
                    var colorArray2 = CurrentColorScheme.ButtonSaveBackColor.GetRgbFromString();
                    var colorArray3 = CurrentColorScheme.ButtonSaveTextColor.GetRgbFromString();
                    button.BackColor = Color.FromArgb(colorArray2[0], colorArray2[1], colorArray2[2]);
                    button.ForeColor = Color.FromArgb(colorArray3[0], colorArray3[1], colorArray3[2]);
                }
            }

            colorArray = CurrentColorScheme.TextboxBackColor.GetRgbFromString();
            colorArray1 = CurrentColorScheme.TextboxTextColor.GetRgbFromString();
            var txb = Controls.OfType<TextBox>().ToList();
            foreach (var textBox in txb)
            {
                textBox.BackColor = Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);
                textBox.ForeColor = Color.FromArgb(colorArray1[0], colorArray1[1], colorArray1[2]);
            }

            var cmbx = Controls.OfType<ComboBox>().ToList();
            foreach (var comboBox in cmbx)
            {
                comboBox.BackColor = Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);
                comboBox.ForeColor = Color.FromArgb(colorArray1[0], colorArray1[1], colorArray1[2]);
            }

            colorArray = CurrentColorScheme.DataGridBackColor.GetRgbFromString();
            dataGridView.BackColor = Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);

            dataGridView.EnableHeadersVisualStyles = false;
            colorArray = CurrentColorScheme.DataGridColumnHeaderBackColor.GetRgbFromString();
            colorArray1 = CurrentColorScheme.DataGridColumnHeaderTextColor.GetRgbFromString();
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(colorArray1[0], colorArray1[1], colorArray1[2]);

            colorArray = CurrentColorScheme.DataGridCellSelectionColor.GetRgbFromString();
            colorArray1 = CurrentColorScheme.DataGridCellSelectionTextColor.GetRgbFromString();
            dataGridView.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);
            dataGridView.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(colorArray1[0], colorArray1[1], colorArray1[2]);


            Colorify();
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            openFileDialog.Filter =
                "Resources (*.resx)|*.resx|" +
                "All files (*.*)|*.*";

            //  Allow the user to select multiple images.
            openFileDialog.Multiselect = true;
            //                   ^  ^  ^  ^  ^  ^  ^

            openFileDialog.Title = "Resources Browser";
        }



        #region MenuEvents

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var dictsList = new List<TranslationDictionary>();
                foreach (var file in openFileDialog.FileNames)
                    // Load resources
                    try
                    {
                        var rr = new ResXResourceReader(file);
                        var dict = new TranslationDictionary();
                        dict.Name = Path.GetFileNameWithoutExtension(file);
                        foreach (DictionaryEntry d in rr)
                            dict.Add(d.Key.ToString(), d.Value.ToString());
                        dictsList.Add(dict);
                        rr.Close();
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                                        "Error message: " + ex.Message + "\n\n" +
                                        "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot display resources: " + file.Substring(file.LastIndexOf('\\'))
                                        + ". You may not have permission to read the file, or " +
                                        "it may be corrupt.\n\nReported error: " + ex.Message);
                    }

                if (dictsList != null)
                {
                    dataGridView.Columns.Add("Key", "Key");
                    var keyColumn = dataGridView.Columns["Key"];
                    keyColumn.Width = 240;

                    for (var i = 0; i < dictsList.Count; i++)
                    {
                        var dict = dictsList[i];
                        dataGridView.Columns.Add(dict.Name, dict.Name);
                        var valueColumn = dataGridView.Columns[dict.Name];
                        valueColumn.Width = 241;
                        foreach (var item in dict)
                        {
                            int rowIndex;
                            if (dataGridView.Contains("Key", item.Key, out rowIndex))
                            {
                                var row = dataGridView.Rows[rowIndex];
                                row.Cells[dict.Name].Value = item.Value;
                            }
                            else
                            {
                                rowIndex = dataGridView.Rows.Add();
                                var row = dataGridView.Rows[rowIndex];
                                row.Cells["Key"].Value = item.Key;
                                row.Cells[dict.Name].Value = item.Value;
                            }
                        }
                    }
                }
            }
            InitView();
            Colorify();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
                if (column.Name != "Key")
                {
                    var dict = new TranslationDictionary {Name = column.Name};
                    foreach (DataGridViewRow item in dataGridView.Rows)
                        dict.Add(item.Cells["Key"].Value?.ToString() ?? string.Empty,
                            item.Cells[column.Name].Value?.ToString() ?? string.Empty);
                    dict.Remove(dict.Keys.Last());
                    using (var resx = new ResXResourceWriter(@".\" + dict.Name + ".resx"))
                    {
                        foreach (var item in dict)
                            resx.AddResource(item.Key, item.Value);
                    }
                }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Selected = true;
                dataGridView.Rows[i].Visible = true;
            }
            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;
            var tempSearchString = textBoxSearch.Text;
            textBoxSearch.Text=String.Empty;
            textBoxSearch.Text = tempSearchString;
        }

        private void untranslatedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUntranslated();
            var tempSearchString = textBoxSearch.Text;
            textBoxSearch.Text = string.Empty;
            textBoxSearch.Text = tempSearchString;
        }

        private void ShowUntranslated()
        {
            var rowIndexes = FindUntranslatedRows();
            for (var i = 0; i < dataGridView.Rows.Count; i++)
                if (rowIndexes.Contains(i))
                {
                    dataGridView.Rows[i].Selected = true;
                    dataGridView.Rows[i].Visible = true;
                }
                else
                {
                    dataGridView.Rows[i].Visible = false;
                    dataGridView.Rows[i].Selected = false;
                }
            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            var dr = settingsForm.ShowDialog();
            if (dr == DialogResult.OK)
                Draw();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == string.Empty)
            {
                searchList = null;
                searchIndex.Text = "0/0";
                buttonSearch.Enabled = false;
                buttonPrev.Enabled = false;
            }
            else
            {
                searchList = new List<RowCellIndex>();
                var searchValue = textBoxSearch.Text;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Visible)
                    {
                        for (var i = 0; i < dataGridView.ColumnCount; i++)
                            if ((row.Cells[i].Value?.ToString() ?? string.Empty).Contains(searchValue))
                            {
                                var rowCellIndex = new RowCellIndex
                                {
                                    RowIndex = row.Index,
                                    CellIndex = i
                                };
                                searchList.Add(rowCellIndex);
                            }
                    }
                }

                if (searchList == null || searchList.Count == 0)
                {
                    searchIndex.Text = "0/0";
                    buttonPrev.Enabled = false;
                    buttonSearch.Enabled = false;
                }
                else
                {
                    buttonSearch.Enabled = true;
                    buttonPrev.Enabled = true;
                    searchListIndex = 0;
                    searchIndex.Text = $@"{searchListIndex + 1}/{searchList.Count}";
                    dataGridView.Rows[searchList[searchListIndex].RowIndex].Cells[searchList[searchListIndex].CellIndex]
                        .Selected = true;
                    dataGridView.CurrentCell = dataGridView.Rows[searchList[searchListIndex].RowIndex]
                        .Cells[searchList[searchListIndex].CellIndex];
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (searchList != null || searchList.Count != 0)
                if (searchListIndex + 2 > searchList.Count)
                {
                    searchListIndex = 0;
                    searchIndex.Text = searchListIndex + 1 + "/" + searchList.Count;
                    dataGridView.Rows[searchList[searchListIndex].RowIndex].Cells[searchList[searchListIndex].CellIndex]
                        .Selected = true;
                    dataGridView.CurrentCell = dataGridView.Rows[searchList[searchListIndex].RowIndex]
                        .Cells[searchList[searchListIndex].CellIndex];
                }
                else
                {
                    searchListIndex++;
                    searchIndex.Text = searchListIndex + 1 + "/" + searchList.Count;
                    dataGridView.Rows[searchList[searchListIndex].RowIndex].Cells[searchList[searchListIndex].CellIndex]
                        .Selected = true;
                    dataGridView.CurrentCell = dataGridView.Rows[searchList[searchListIndex].RowIndex]
                        .Cells[searchList[searchListIndex].CellIndex];
                }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (searchList != null || searchList.Count != 0)
                if (searchListIndex + 1 < 2)
                {
                    searchListIndex = searchList.Count - 1;
                    searchIndex.Text = searchListIndex + 1 + "/" + searchList.Count;
                    dataGridView.Rows[searchList[searchListIndex].RowIndex].Cells[searchList[searchListIndex].CellIndex]
                        .Selected = true;
                    dataGridView.CurrentCell = dataGridView.Rows[searchList[searchListIndex].RowIndex]
                        .Cells[searchList[searchListIndex].CellIndex];
                }
                else
                {
                    searchListIndex--;
                    searchIndex.Text = searchListIndex + 1 + "/" + searchList.Count;
                    dataGridView.Rows[searchList[searchListIndex].RowIndex].Cells[searchList[searchListIndex].CellIndex]
                        .Selected = true;
                    dataGridView.CurrentCell = dataGridView.Rows[searchList[searchListIndex].RowIndex]
                        .Cells[searchList[searchListIndex].CellIndex];
                }
        }

        #endregion

        #region PrivateMembers

        private void Colorify()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
                for (var i = 0; i < dataGridView.ColumnCount; i++)
                    if ((string) row.Cells[i].Tag == "Untranslated")
                    {
                        row.Cells[i].Tag = "Translated";
                        var colorArray = CurrentColorScheme.DataGridCellTransaltedColor.GetRgbFromString();
                        var colorArray1 = CurrentColorScheme.DataGridCellTransaltedTextColor.GetRgbFromString();
                        row.Cells[i].Style.BackColor = Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);
                        row.Cells[i].Style.ForeColor = Color.FromArgb(colorArray1[0], colorArray1[1], colorArray1[2]);
                    }
                    else
                    {
                        var colorArray = CurrentColorScheme.DataGridRowDefaultColor.GetRgbFromString();
                        var colorArray1 = CurrentColorScheme.DataGridRowTextDefaultColor.GetRgbFromString();
                        row.Cells[i].Style.BackColor = Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);
                        row.Cells[i].Style.ForeColor = Color.FromArgb(colorArray1[0], colorArray1[1], colorArray1[2]);
                    }
            var indexes = FindUntranslatedCells();
            foreach (var index in indexes)
            {
                dataGridView.Rows[index.RowIndex].Cells[index.CellIndex].Tag = "Untranslated";
                var colorArray = CurrentColorScheme.DataGridCellUntransaltedColor.GetRgbFromString();
                var colorArray1 = CurrentColorScheme.DataGridCellUntransaltedTextColor.GetRgbFromString();
                dataGridView.Rows[index.RowIndex].Cells[index.CellIndex].Style.BackColor =
                    Color.FromArgb(colorArray[0], colorArray[1], colorArray[2]);
                dataGridView.Rows[index.RowIndex].Cells[index.CellIndex].Style.ForeColor =
                    Color.FromArgb(colorArray1[0], colorArray1[1], colorArray1[2]);
            }
        }

        private List<int> FindUntranslatedRows()
        {
            var searchValue = string.Empty;
            var list = new List<int>();
            foreach (DataGridViewRow row in dataGridView.Rows)
                for (var i = 0; i < dataGridView.ColumnCount; i++)
                    if ((row.Cells[i].Value?.ToString() ?? string.Empty) == searchValue)
                        if (!list.Contains(row.Index))
                            list.Add(row.Index);
            return list;
        }

        private List<RowCellIndex> FindUntranslatedCells()
        {
            var searchValue = string.Empty;
            var list = new List<RowCellIndex>();
            foreach (DataGridViewRow row in dataGridView.Rows)
                for (var i = 0; i < dataGridView.ColumnCount; i++)
                    if ((row.Cells[i].Value?.ToString() ?? string.Empty) == searchValue)
                    {
                        var rowCellIndex = new RowCellIndex
                        {
                            RowIndex = row.Index,
                            CellIndex = i
                        };
                        list.Add(rowCellIndex);
                    }
            return list;
        }


        private void InitView()
        {
            var columnDict = new Dictionary<int, string>();
            foreach (DataGridViewColumn column in dataGridView.Columns)
                if (column.Name != "Key")
                    columnDict.Add(column.Index, column.Name);
            if (dataGridView.ColumnCount > 0)
            {
                buttonAdd.Enabled = true;
                textBoxKey.Enabled = true;
                textBoxLanguage1.Enabled = true;
                textBoxSearch.Enabled = true;
                if (dataGridView.ColumnCount > 1)
                {
                    textBoxLanguage1.Enabled = true;
                    comboBoxLanguage1.Enabled = true;
                    comboBoxLanguage1.DataSource = new BindingSource(columnDict, null);
                    comboBoxLanguage1.DisplayMember = "Value";
                    comboBoxLanguage1.ValueMember = "Key";
                    comboBoxLanguage1.SelectedIndex = 0;


                    textBoxLanguage2.Enabled = true;
                    comboBoxLanguage2.Enabled = true;
                    comboBoxLanguage2.DataSource = new BindingSource(columnDict, null);
                    comboBoxLanguage2.DisplayMember = "Value";
                    comboBoxLanguage2.ValueMember = "Key";
                    comboBoxLanguage2.SelectedIndex = 1;


                    if (dataGridView.ColumnCount > 2)
                    {
                        textBoxLanguage3.Enabled = true;
                        comboBoxLanguage3.Enabled = true;
                        comboBoxLanguage3.DataSource = new BindingSource(columnDict, null);
                        comboBoxLanguage3.DisplayMember = "Value";
                        comboBoxLanguage3.ValueMember = "Key";
                        comboBoxLanguage3.SelectedIndex = 2;
                    }
                }
                dataGridView.SelectionChanged += dataGridView_SelectionChanged;
                dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            }
        }

        #endregion

        #region Events
        private void DataGridForm_Load(object sender, EventArgs e)
        {
            Colorify();
        }

        private void comboBoxLanguage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelLanguage1.Text = comboBoxLanguage1.GetItemText(comboBoxLanguage1.SelectedItem) + ":";
        }

        private void comboBoxLanguage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelLanguage2.Text = comboBoxLanguage2.GetItemText(comboBoxLanguage2.SelectedItem) + ":";
        }

        private void comboBoxLanguage3_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelLanguage3.Text = comboBoxLanguage1.GetItemText(comboBoxLanguage3.SelectedItem) + ":";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int rowIndex;
            if (dataGridView.Contains("Key", textBoxKey.Text, out rowIndex))
            {
                var row = dataGridView.Rows[rowIndex];
                row.Cells[comboBoxLanguage1.GetItemText(comboBoxLanguage1.SelectedItem)].Value = textBoxLanguage1.Text;
                if (comboBoxLanguage1.Items.Count > 1)
                {
                    row.Cells[comboBoxLanguage2.GetItemText(comboBoxLanguage2.SelectedItem)].Value =
                        textBoxLanguage2.Text;
                    if (comboBoxLanguage1.Items.Count > 2)
                        row.Cells[comboBoxLanguage3.GetItemText(comboBoxLanguage3.SelectedItem)].Value =
                            textBoxLanguage3.Text;
                }
            }
            else
            {
                rowIndex = dataGridView.Rows.Add();
                var row = dataGridView.Rows[rowIndex];
                row.Cells["Key"].Value = textBoxKey.Text;
                row.Cells[comboBoxLanguage1.GetItemText(comboBoxLanguage1.SelectedItem)].Value = textBoxLanguage1.Text;
                if (comboBoxLanguage1.Items.Count > 1)
                {
                    row.Cells[comboBoxLanguage2.GetItemText(comboBoxLanguage2.SelectedItem)].Value =
                        textBoxLanguage2.Text;
                    if (comboBoxLanguage1.Items.Count > 2)
                        row.Cells[comboBoxLanguage3.GetItemText(comboBoxLanguage3.SelectedItem)].Value =
                            textBoxLanguage3.Text;
                }
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Colorify();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var curRow = dataGridView.Rows[dataGridView.CurrentRow.Index];
                textBoxKey.Text = curRow.Cells["Key"].Value?.ToString() ?? string.Empty;

                if (textBoxKey.Text == string.Empty)
                    buttonAdd.Text = "Add";
                else
                    buttonAdd.Text = "Edit";

                textBoxLanguage1.Text = curRow.Cells[comboBoxLanguage1.GetItemText(comboBoxLanguage1.SelectedItem)]
                                            .Value?.ToString() ?? string.Empty;
                textBoxLanguage2.Text = curRow.Cells[comboBoxLanguage2.GetItemText(comboBoxLanguage2.SelectedItem)]
                                            .Value?.ToString() ?? string.Empty;
                textBoxLanguage3.Text = curRow.Cells[comboBoxLanguage3.GetItemText(comboBoxLanguage3.SelectedItem)]
                                            .Value?.ToString() ?? string.Empty;
            }
        }

        #endregion
    }
}