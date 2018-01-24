namespace LocalizerDesktop
{
    partial class SettingsForm
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonFolderSelect = new System.Windows.Forms.Button();
            this.labelBackup = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.buttonEditCustom = new System.Windows.Forms.Button();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonAlternate = new System.Windows.Forms.RadioButton();
            this.radioButtonDark = new System.Windows.Forms.RadioButton();
            this.radioButtonLight = new System.Windows.Forms.RadioButton();
            this.groupBoxStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(89, 20);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(266, 20);
            this.textBoxFolder.TabIndex = 0;
            // 
            // buttonFolderSelect
            // 
            this.buttonFolderSelect.Location = new System.Drawing.Point(361, 18);
            this.buttonFolderSelect.Name = "buttonFolderSelect";
            this.buttonFolderSelect.Size = new System.Drawing.Size(40, 23);
            this.buttonFolderSelect.TabIndex = 1;
            this.buttonFolderSelect.Text = ". . .";
            this.buttonFolderSelect.UseVisualStyleBackColor = true;
            this.buttonFolderSelect.Click += new System.EventHandler(this.buttonFolderSelect_Click);
            // 
            // labelBackup
            // 
            this.labelBackup.AutoSize = true;
            this.labelBackup.Location = new System.Drawing.Point(12, 23);
            this.labelBackup.Name = "labelBackup";
            this.labelBackup.Size = new System.Drawing.Size(71, 13);
            this.labelBackup.TabIndex = 2;
            this.labelBackup.Text = "Backup path:";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(171, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.Controls.Add(this.buttonEditCustom);
            this.groupBoxStyle.Controls.Add(this.radioButtonCustom);
            this.groupBoxStyle.Controls.Add(this.radioButtonAlternate);
            this.groupBoxStyle.Controls.Add(this.radioButtonDark);
            this.groupBoxStyle.Controls.Add(this.radioButtonLight);
            this.groupBoxStyle.Location = new System.Drawing.Point(15, 82);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(386, 138);
            this.groupBoxStyle.TabIndex = 5;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "Style";
            // 
            // buttonEditCustom
            // 
            this.buttonEditCustom.Location = new System.Drawing.Point(319, 69);
            this.buttonEditCustom.Name = "buttonEditCustom";
            this.buttonEditCustom.Size = new System.Drawing.Size(62, 23);
            this.buttonEditCustom.TabIndex = 4;
            this.buttonEditCustom.Text = "Edit";
            this.buttonEditCustom.UseVisualStyleBackColor = true;
            this.buttonEditCustom.Click += new System.EventHandler(this.buttonEditCustom_Click);
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(321, 19);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(60, 17);
            this.radioButtonCustom.TabIndex = 3;
            this.radioButtonCustom.Text = "Custom";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            this.radioButtonCustom.CheckedChanged += new System.EventHandler(this.radioButtonCustom_CheckedChanged);
            // 
            // radioButtonAlternate
            // 
            this.radioButtonAlternate.AutoSize = true;
            this.radioButtonAlternate.Location = new System.Drawing.Point(222, 19);
            this.radioButtonAlternate.Name = "radioButtonAlternate";
            this.radioButtonAlternate.Size = new System.Drawing.Size(67, 17);
            this.radioButtonAlternate.TabIndex = 2;
            this.radioButtonAlternate.Text = "Alternate";
            this.radioButtonAlternate.UseVisualStyleBackColor = true;
            this.radioButtonAlternate.CheckedChanged += new System.EventHandler(this.radioButtonAlternate_CheckedChanged);
            // 
            // radioButtonDark
            // 
            this.radioButtonDark.AutoSize = true;
            this.radioButtonDark.Location = new System.Drawing.Point(120, 19);
            this.radioButtonDark.Name = "radioButtonDark";
            this.radioButtonDark.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDark.TabIndex = 1;
            this.radioButtonDark.Text = "Dark";
            this.radioButtonDark.UseVisualStyleBackColor = true;
            this.radioButtonDark.CheckedChanged += new System.EventHandler(this.radioButtonDark_CheckedChanged);
            // 
            // radioButtonLight
            // 
            this.radioButtonLight.AutoSize = true;
            this.radioButtonLight.Checked = true;
            this.radioButtonLight.Location = new System.Drawing.Point(19, 19);
            this.radioButtonLight.Name = "radioButtonLight";
            this.radioButtonLight.Size = new System.Drawing.Size(48, 17);
            this.radioButtonLight.TabIndex = 0;
            this.radioButtonLight.TabStop = true;
            this.radioButtonLight.Text = "Light";
            this.radioButtonLight.UseVisualStyleBackColor = true;
            this.radioButtonLight.CheckedChanged += new System.EventHandler(this.radioButtonLight_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.groupBoxStyle);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelBackup);
            this.Controls.Add(this.buttonFolderSelect);
            this.Controls.Add(this.textBoxFolder);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonFolderSelect;
        private System.Windows.Forms.Label labelBackup;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.RadioButton radioButtonLight;
        private System.Windows.Forms.RadioButton radioButtonAlternate;
        private System.Windows.Forms.RadioButton radioButtonDark;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.Button buttonEditCustom;
    }
}