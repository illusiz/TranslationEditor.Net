namespace LocalizerDesktop
{
    partial class DataGridForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untranslatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxLanguage1 = new System.Windows.Forms.TextBox();
            this.textBoxLanguage2 = new System.Windows.Forms.TextBox();
            this.textBoxLanguage3 = new System.Windows.Forms.TextBox();
            this.comboBoxLanguage1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguage2 = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguage3 = new System.Windows.Forms.ComboBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelLanguage1 = new System.Windows.Forms.Label();
            this.labelLanguage2 = new System.Windows.Forms.Label();
            this.labelLanguage3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.searchIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(984, 554);
            this.dataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.untranslatedToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // untranslatedToolStripMenuItem
            // 
            this.untranslatedToolStripMenuItem.Name = "untranslatedToolStripMenuItem";
            this.untranslatedToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.untranslatedToolStripMenuItem.Text = "Untranslated";
            this.untranslatedToolStripMenuItem.Click += new System.EventHandler(this.untranslatedToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Enabled = false;
            this.textBoxKey.Location = new System.Drawing.Point(92, 596);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(751, 20);
            this.textBoxKey.TabIndex = 2;
            // 
            // textBoxLanguage1
            // 
            this.textBoxLanguage1.Enabled = false;
            this.textBoxLanguage1.Location = new System.Drawing.Point(92, 622);
            this.textBoxLanguage1.Name = "textBoxLanguage1";
            this.textBoxLanguage1.Size = new System.Drawing.Size(751, 20);
            this.textBoxLanguage1.TabIndex = 3;
            // 
            // textBoxLanguage2
            // 
            this.textBoxLanguage2.Enabled = false;
            this.textBoxLanguage2.Location = new System.Drawing.Point(92, 648);
            this.textBoxLanguage2.Name = "textBoxLanguage2";
            this.textBoxLanguage2.Size = new System.Drawing.Size(751, 20);
            this.textBoxLanguage2.TabIndex = 4;
            // 
            // textBoxLanguage3
            // 
            this.textBoxLanguage3.Enabled = false;
            this.textBoxLanguage3.Location = new System.Drawing.Point(92, 674);
            this.textBoxLanguage3.Name = "textBoxLanguage3";
            this.textBoxLanguage3.Size = new System.Drawing.Size(751, 20);
            this.textBoxLanguage3.TabIndex = 5;
            // 
            // comboBoxLanguage1
            // 
            this.comboBoxLanguage1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage1.Enabled = false;
            this.comboBoxLanguage1.FormattingEnabled = true;
            this.comboBoxLanguage1.Location = new System.Drawing.Point(849, 621);
            this.comboBoxLanguage1.Name = "comboBoxLanguage1";
            this.comboBoxLanguage1.Size = new System.Drawing.Size(147, 21);
            this.comboBoxLanguage1.TabIndex = 6;
            this.comboBoxLanguage1.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage1_SelectedIndexChanged);
            // 
            // comboBoxLanguage2
            // 
            this.comboBoxLanguage2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage2.Enabled = false;
            this.comboBoxLanguage2.FormattingEnabled = true;
            this.comboBoxLanguage2.Location = new System.Drawing.Point(849, 647);
            this.comboBoxLanguage2.Name = "comboBoxLanguage2";
            this.comboBoxLanguage2.Size = new System.Drawing.Size(147, 21);
            this.comboBoxLanguage2.TabIndex = 7;
            this.comboBoxLanguage2.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage2_SelectedIndexChanged);
            // 
            // comboBoxLanguage3
            // 
            this.comboBoxLanguage3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage3.Enabled = false;
            this.comboBoxLanguage3.FormattingEnabled = true;
            this.comboBoxLanguage3.Location = new System.Drawing.Point(849, 673);
            this.comboBoxLanguage3.Name = "comboBoxLanguage3";
            this.comboBoxLanguage3.Size = new System.Drawing.Size(147, 21);
            this.comboBoxLanguage3.TabIndex = 8;
            this.comboBoxLanguage3.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage3_SelectedIndexChanged);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(58, 599);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(28, 13);
            this.labelKey.TabIndex = 9;
            this.labelKey.Text = "Key:";
            // 
            // labelLanguage1
            // 
            this.labelLanguage1.AutoSize = true;
            this.labelLanguage1.Location = new System.Drawing.Point(19, 624);
            this.labelLanguage1.Name = "labelLanguage1";
            this.labelLanguage1.Size = new System.Drawing.Size(67, 13);
            this.labelLanguage1.TabIndex = 10;
            this.labelLanguage1.Text = "Language 1:";
            // 
            // labelLanguage2
            // 
            this.labelLanguage2.AutoSize = true;
            this.labelLanguage2.Location = new System.Drawing.Point(19, 651);
            this.labelLanguage2.Name = "labelLanguage2";
            this.labelLanguage2.Size = new System.Drawing.Size(67, 13);
            this.labelLanguage2.TabIndex = 11;
            this.labelLanguage2.Text = "Language 2:";
            // 
            // labelLanguage3
            // 
            this.labelLanguage3.AutoSize = true;
            this.labelLanguage3.Location = new System.Drawing.Point(19, 677);
            this.labelLanguage3.Name = "labelLanguage3";
            this.labelLanguage3.Size = new System.Drawing.Size(67, 13);
            this.labelLanguage3.TabIndex = 12;
            this.labelLanguage3.Text = "Language 3:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(849, 594);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(147, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Tag = "Save";
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Enabled = false;
            this.textBoxSearch.Location = new System.Drawing.Point(673, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(176, 20);
            this.textBoxSearch.TabIndex = 14;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(954, 1);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(42, 22);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = ">";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(855, 1);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(42, 22);
            this.buttonPrev.TabIndex = 16;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // searchIndex
            // 
            this.searchIndex.AutoSize = true;
            this.searchIndex.Location = new System.Drawing.Point(903, 6);
            this.searchIndex.Name = "searchIndex";
            this.searchIndex.Size = new System.Drawing.Size(0, 13);
            this.searchIndex.TabIndex = 17;
            this.searchIndex.Tag = "Menu";
            this.searchIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.searchIndex);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelLanguage3);
            this.Controls.Add(this.labelLanguage2);
            this.Controls.Add(this.labelLanguage1);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.comboBoxLanguage3);
            this.Controls.Add(this.comboBoxLanguage2);
            this.Controls.Add(this.comboBoxLanguage1);
            this.Controls.Add(this.textBoxLanguage3);
            this.Controls.Add(this.textBoxLanguage2);
            this.Controls.Add(this.textBoxLanguage1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataGridForm";
            this.Text = "Translation Editor";
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untranslatedToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxLanguage1;
        private System.Windows.Forms.TextBox textBoxLanguage2;
        private System.Windows.Forms.TextBox textBoxLanguage3;
        private System.Windows.Forms.ComboBox comboBoxLanguage1;
        private System.Windows.Forms.ComboBox comboBoxLanguage2;
        private System.Windows.Forms.ComboBox comboBoxLanguage3;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelLanguage1;
        private System.Windows.Forms.Label labelLanguage2;
        private System.Windows.Forms.Label labelLanguage3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label searchIndex;
    }
}

