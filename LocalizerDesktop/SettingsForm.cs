using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalizerDesktop
{
    public partial class SettingsForm : Form
    {
        private string colorScheme;
        public SettingsForm()
        {
            InitializeComponent();
            var settings = Utils.LoadConfig();
            switch (settings.CurrentColorScheme)
            {
                case "Light":
                    radioButtonLight.Checked = true;
                    break;
                case "Dark":
                    radioButtonDark.Checked = true;
                    break;
                case "Alternate":
                    radioButtonAlternate.Checked = true;
                    break;
                case "Custom":
                    radioButtonCustom.Checked = true;
                    break;
            }
        }

        #region Events
        private void buttonFolderSelect_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var settings = new Settings
            {
                CurrentColorScheme = colorScheme,
                BackupPath = textBoxFolder.Text
            };
            Utils.SaveConfig(settings);
            Utils.SetCurrentColorScheme(colorScheme);
            this.Close();
        }

        #endregion


        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {

            colorScheme = "Custom";
        }

        private void radioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            colorScheme = "Light";
        }

        private void radioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            colorScheme = "Dark";
        }

        private void radioButtonAlternate_CheckedChanged(object sender, EventArgs e)
        {
            colorScheme = "Alternate";
        }

        private void buttonEditCustom_Click(object sender, EventArgs e)
        {
            var colorSchemeEditor = new ColorSchemeEditor();
            colorSchemeEditor.ShowDialog();
        }
    }
}
