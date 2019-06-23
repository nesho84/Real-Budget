using System;
using System.Windows.Forms;

namespace RealBudgetUI.RBSettings
{
    public partial class RBSettings : UserControl
    {
        public RBSettings()
        {
            InitializeComponent();

            GetAutomaticLoginStatus();
        }

        private void Enable_Disable_AutoLogin()
        {
            // Disable AutomaticLogin
            if (Properties.Settings.Default.automaticLogin == true)
            {
                if (MessageBox.Show(
                    "Are you sure you want to disable Automatic Login?\n",
                    "RealBudget®", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Change value in appsettings for AutomaticLogin
                    Properties.Settings.Default.automaticLogin = false;
                    Properties.Settings.Default.Save();

                    //Change image and text of the Button
                    Btn_AutoLogin.Image = RealBudgetUI.Properties.Resources.unlock_40px;
                    Btn_AutoLogin.Text = "   Automatic Login is\n Disabled.";
                }
            }
            // Enable AutomaticLogin
            else
            {
                if (MessageBox.Show(
                    "Are you sure you want to enable Automatic Login?\n",
                    "RealBudget®", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Change value in appsettings for AutomaticLogin
                    Properties.Settings.Default.automaticLogin = true;
                    Properties.Settings.Default.rememberLogin = true;
                    Properties.Settings.Default.Save();

                    //Change image and text of the Button
                    Btn_AutoLogin.Image = RealBudgetUI.Properties.Resources.unlock_40px;
                    Btn_AutoLogin.Text = "   Automatic Login is\n Enabled.";
                }
            }
        }

        private void GetAutomaticLoginStatus()
        {
            //Check Automatic login button and change the text
            if (Properties.Settings.Default.automaticLogin == true)
            {
                Btn_AutoLogin.Text = "   Disable Automatic Login";
                Btn_AutoLogin.Image = RealBudgetUI.Properties.Resources.unlock_40px;
            }
            else
            {
                Btn_AutoLogin.Text = "   Enable Automatic Login";
                Btn_AutoLogin.Image = RealBudgetUI.Properties.Resources.lock_40px;
            }
        }

        private void Btn_Database_Click(object sender, EventArgs e)
        {
            RBSettings_DBLocation LgSdb = new RBSettings_DBLocation();
            {
                LgSdb.ShowDialog();
            }
        }

        private void Btn_AutoLogin_Click(object sender, EventArgs e)
        {
            Enable_Disable_AutoLogin();
        }

        private void Btn_EmailSettings_Click(object sender, EventArgs e)
        {
            RBSettings_Email frm = new RBSettings_Email();
            frm.ShowDialog();
        }

        private void Btn_Theme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction...", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_Language_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction...", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_Currency_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction...", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_Notifications_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction...", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_Backup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction...", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_DeleteAcount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction...", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
