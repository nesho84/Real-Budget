using System;
using System.Windows.Forms;

namespace RealBudgetUI.RBSettings
{
    public partial class RBSettings_DBLocation : Form
    {
        public RBSettings_DBLocation()
        {
            InitializeComponent();

            TextBoxFolderPath.Text = Properties.Settings.Default.UserDbPath;
        }

        private void Open_FileDialog()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            {
                dlg.Filter = "Database Files(*.db)|*.db";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string dbPath = dlg.FileName.ToString();
                    TextBoxFolderPath.Text = dbPath;
                }
            }
        }

        private void Save_Location()
        {
            if (MessageBox.Show("Are you sure you want to change Database Location?\n\nNote: Changing your Database Location " +
               "or the Current Database File can make this Application unstable!",
               "RealBudget®", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    Properties.Settings.Default.UserDbPath = TextBoxFolderPath.Text;
                    Properties.Settings.Default.Save();

                    MessageBox.Show("Database Location was changed successfully. You must restart the Application to apply these changes.", "RealBudget®", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void ButtonFolder_Click(object sender, EventArgs e)
        {
            Open_FileDialog();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save_Location();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
