using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI.Login
{
    public partial class Login : Form
    {
        //UserModel data
        private UsersModel user = new UsersModel();

        public Login()
        {
            InitializeComponent();

            CheckSQLiteConnection();

            LoginFormShow();
        }

         private void LoginFormShow()
        {
            //Avoid Losing Focus of the Login Form
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            //Getting User data from database
            user = UsersDataProcessor.GetAllUsers().Find(x => x.User_Id == GlobalConfig.GetUID());

            //user.User_Id = 1;
            //UID = 0;

            //Save in Properties.Settings.Default - if the UID is set
            if (user != null)
            {
                if (user.User_Id == GlobalConfig.GetUID())
                {
                    //Check RememberMe checkbox
                    if (Properties.Settings.Default.rememberLogin == true)
                    {
                        checkBoxSaveLogin.Checked = true;
                        TxtUsername.Text = user.Username;
                        TxtPassword.Text = user.Password;

                        // Check Automatic Login
                        if (Properties.Settings.Default.automaticLogin == true)
                        {
                            //Go direct to Dashboard form
                            this.Hide();
                            Dashboard frm = new Dashboard();
                            frm.lblTop_Info_Welcome.Text = $"Hello { user.Username } ({ user.User_Id })";
                            frm.ShowDialog();
                        }
                    } 
                }
            }
            else
            {
                //Update the App.config file
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["UID"].Value = "0";
                config.AppSettings.Settings["UserCurrency"].Value = "";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                //Save properties.setttings.default
                Properties.Settings.Default.rememberLogin = false;
                Properties.Settings.Default.automaticLogin = false;
                checkBoxSaveLogin.Checked = false;
                TxtUsername.Text = null;
                TxtPassword.Text = null;
                Properties.Settings.Default.Save();
            }
        }

        private void CheckSQLiteConnection()
        {
            if (GlobalConfig.CheckDBConnection())
            {
                ImageDisconnected.Hide();
                ImageConnected.Show();
            }
            else if (!GlobalConfig.CheckDBConnection())
            {
                UserPass_groupBox.Enabled = false;
                InfoRegisterGroupBox.Enabled = false;
                ImageDisconnected.Show();
                ImageConnected.Hide();
                Btn_Login.BackColor = SystemColors.InactiveCaption;
                Btn_FindDB.Dock = DockStyle.Fill;
                Btn_FindDB.Visible = true;
            }
        }       

        private void CheckAndSaveUserData()
        {
            try
            {
                //Getting the current User from the database
                user = UsersDataProcessor.GetAllUsers().Find(x => (x.Username == TxtUsername.Text && x.Password == TxtPassword.Text));

                //Counting All users from the database
                int usersCount = UsersDataProcessor.GetAllUsers().FindAll(x => (x.Username == TxtUsername.Text && x.Password == TxtPassword.Text)).Count();

                //Check if the User is Blocked
                if (user != null && user.Blocked == "yes")
                {
                    MessageBox.Show("Your Account has been blocked. Please contact your RealBudget Administrator.", "RealBudget®", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Main_tableLayoutPanel.Enabled = false;
                    return;
                }

                //If the User exists in the database
                if (usersCount == 1)
                {
                    //Store User_Id and User_Currency in App.config
                    if (user != null)
                    {
                        //Update the App.config file
                        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["UID"].Value = user.User_Id.ToString();
                        config.AppSettings.Settings["UserCurrency"].Value = user.User_Currency;
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                    }
                    //Save to App Settings if checkbox checked
                    if (checkBoxSaveLogin.Checked == true)
                    {
                        Properties.Settings.Default.rememberLogin = true;
                        Properties.Settings.Default.Save();
                    }
                    else if (checkBoxSaveLogin.Checked == false)
                    {
                        Properties.Settings.Default.rememberLogin = false;
                        Properties.Settings.Default.Save();
                    }

                    //Hide Login and go to Dashboard
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    ///Get UserName posted from Login
                    dashboard.lblTop_Info_Welcome.Text = $"Hello { user.Username } ({ user.User_Id })";
                    dashboard.ShowDialog();
                }

                else if (usersCount < 1)
                {
                    MessageBox.Show("Incorrect Username or Password!", "RealBudget®", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (usersCount > 1)
                {
                    MessageBox.Show("Duplicated User! Please contact your RealBudget Administrator.", "RealBudget®", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.", "RealBudget®", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            CheckAndSaveUserData();
        }

        private void LinkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Register rgr = new Login_Register();
            rgr.ShowDialog();
        }

        private void LinkLblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_PassReset pwdr = new Login_PassReset();
            pwdr.ShowDialog();
        }

        private void Btn_FindDB_Click(object sender, EventArgs e)
        {
            RBSettings.RBSettings_DBLocation LgSch = new RBSettings.RBSettings_DBLocation();
            LgSch.ShowDialog();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Asking the user if he is sure to close the App
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "RealBudget", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}