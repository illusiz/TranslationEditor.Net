using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalizerDesktop
{
    public partial class ColorSchemeEditor : Form
    {
        public ColorScheme CustomColorScheme;
        public ColorScheme NewCustomColorScheme;
        public ColorSchemeEditor()
        {
            InitializeComponent();
            InitView();
        }

        private void InitView()
        {
            var customColorScheme = Utils.LoadColorSchemes()[3];
            dataGridView.Columns.Add("Key", "Key");
            dataGridView.Columns.Add("Value", "Value");
            dataGridView.Columns["Key"].Width = 230;
            dataGridView.Columns["Value"].Width = 155;
            var rowIndex = this.dataGridView.Rows.Add();
            var row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.FormMainColor);
            row.Cells["Value"].Value = customColorScheme.FormMainColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.LabelBackColor);
            row.Cells["Value"].Value = customColorScheme.LabelBackColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.LabelTextColor);
            row.Cells["Value"].Value = customColorScheme.LabelTextColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.FormMenuBackColor);
            row.Cells["Value"].Value = customColorScheme.FormMenuBackColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.FormMenuTextColor);
            row.Cells["Value"].Value = customColorScheme.FormMenuTextColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.ButtonsBackColor);
            row.Cells["Value"].Value = customColorScheme.ButtonsBackColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.ButtonsTextColor);
            row.Cells["Value"].Value = customColorScheme.ButtonsTextColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.TextboxBackColor);
            row.Cells["Value"].Value = customColorScheme.TextboxBackColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.TextboxTextColor);
            row.Cells["Value"].Value = customColorScheme.TextboxTextColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.ButtonSaveBackColor);
            row.Cells["Value"].Value = customColorScheme.ButtonSaveBackColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.ButtonsTextColor);
            row.Cells["Value"].Value = customColorScheme.ButtonsTextColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridBackColor);
            row.Cells["Value"].Value = customColorScheme.DataGridBackColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridColumnHeaderBackColor);
            row.Cells["Value"].Value = customColorScheme.DataGridColumnHeaderBackColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridColumnHeaderTextColor);
            row.Cells["Value"].Value = customColorScheme.DataGridColumnHeaderTextColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridRowDefaultColor);
            row.Cells["Value"].Value = customColorScheme.DataGridRowDefaultColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridRowTextDefaultColor);
            row.Cells["Value"].Value = customColorScheme.DataGridRowTextDefaultColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridCellUntransaltedColor);
            row.Cells["Value"].Value = customColorScheme.DataGridCellUntransaltedColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridCellUntransaltedTextColor);
            row.Cells["Value"].Value = customColorScheme.DataGridCellUntransaltedTextColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridCellTransaltedColor);
            row.Cells["Value"].Value = customColorScheme.DataGridCellTransaltedColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridCellTransaltedTextColor);
            row.Cells["Value"].Value = customColorScheme.DataGridCellTransaltedTextColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridCellSelectionColor);
            row.Cells["Value"].Value = customColorScheme.DataGridCellSelectionColor;
            rowIndex = this.dataGridView.Rows.Add();
            row = this.dataGridView.Rows[rowIndex];
            row.Cells["Key"].Value = nameof(customColorScheme.DataGridCellSelectionTextColor);
            row.Cells["Value"].Value = customColorScheme.DataGridCellSelectionTextColor;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewCustomColorScheme = new ColorScheme();
            NewCustomColorScheme.FormMainColor = dataGridView.Rows[0].Cells[1].Value.ToString();
            NewCustomColorScheme.LabelBackColor = dataGridView.Rows[1].Cells[1].Value.ToString();
            NewCustomColorScheme.LabelTextColor = dataGridView.Rows[2].Cells[1].Value.ToString();
            NewCustomColorScheme.FormMenuBackColor = dataGridView.Rows[3].Cells[1].Value.ToString();
            NewCustomColorScheme.FormMenuTextColor = dataGridView.Rows[4].Cells[1].Value.ToString();
            NewCustomColorScheme.ButtonsBackColor = dataGridView.Rows[5].Cells[1].Value.ToString();
            NewCustomColorScheme.ButtonsTextColor = dataGridView.Rows[6].Cells[1].Value.ToString();
            NewCustomColorScheme.TextboxBackColor = dataGridView.Rows[7].Cells[1].Value.ToString();
            NewCustomColorScheme.TextboxTextColor = dataGridView.Rows[8].Cells[1].Value.ToString();
            NewCustomColorScheme.ButtonSaveBackColor = dataGridView.Rows[9].Cells[1].Value.ToString();
            NewCustomColorScheme.ButtonsTextColor = dataGridView.Rows[10].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridBackColor = dataGridView.Rows[11].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridColumnHeaderBackColor = dataGridView.Rows[12].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridColumnHeaderTextColor = dataGridView.Rows[13].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridRowDefaultColor = dataGridView.Rows[14].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridRowTextDefaultColor = dataGridView.Rows[15].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridCellUntransaltedColor = dataGridView.Rows[16].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridCellUntransaltedTextColor = dataGridView.Rows[17].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridCellTransaltedColor = dataGridView.Rows[18].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridCellTransaltedTextColor = dataGridView.Rows[19].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridCellSelectionColor = dataGridView.Rows[20].Cells[1].Value.ToString();
            NewCustomColorScheme.DataGridCellSelectionTextColor = dataGridView.Rows[21].Cells[1].Value.ToString();
            Utils.SaveCustomColorScheme(NewCustomColorScheme);
            this.Close();
        }

    }
}
