using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI
{
    public partial class Dashboard : Form
    {
        //Menustrip Item color when selected
        private readonly Color SelectedColor = System.Drawing.SystemColors.GradientInactiveCaption;

        public Dashboard()
        {
            InitializeComponent();

            //Loading First Data
            LoadFormData();
            //Check if the User Access_Role is admin
            CheckIfAdmin();
            //Calculate number of All Transactions
            GetNumberOfTransactions();
            //Calculate Balance of All Accounts
            AccountsBalance();
            //Calculate number of All Reminders
            GetNumberOfReminders();
            //Load Category Boxes or Buttons
            Load_Category_Boxes();
        }

        private void LoadFormData()
        {
            //Change Main MENU cursor to Hand
            Main_Top_menuStrip.Cursor = Cursors.Hand;
            //Mark Home Menu as Selected
            HOMEToolStripMenuItem.BackColor = SelectedColor;

            //this Application and Version
            this.Text = $"{Application.ProductName}  {Application.ProductVersion}";

            lbl_Today_Date_Time.Text = DateTime.Now.ToString("dddd,\ndd MMMM yyyy");

            DashBoardTimer.Start();
        }

        private void CheckIfAdmin()
        {
            try
            {
                UsersModel user = new UsersModel();

                if (user.IsAdmin() == false)
                {
                    USERSToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Confirm_Logout()
        {
            //Confirm if the user wants realy to logout
            if (MessageBox.Show("Are you sure you want to Logout?\n\nNote: this will " +
                                "disable Automatic Login for next time you Login.",
                                "RealBudget®", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Restart Application
                try
                {
                    //Save to properties.settings
                    Properties.Settings.Default.automaticLogin = false;
                    Properties.Settings.Default.Save();

                    //Avoid Event on form exit or stop the event form closing
                    this.FormClosing -= Dashboard_FormClosing;

                    //run the program again
                    System.Diagnostics.Process.Start(Application.ExecutablePath);

                    //close this one
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        private void GetNumberOfReminders()
        {
            ReminderModel reminder = new ReminderModel();

            lblNotification.Text = $"You have ({ reminder.CountReminders().ToString() }) unseen Notifications";

            if (reminder.CountReminders() == 0)
            {
                Btn_OpenNotification.Enabled = false;
            }
            else
            {
                Btn_OpenNotification.Enabled = true;
            }
        }

        public void GetNumberOfTransactions()
        {
            TransactionsModel transaction = new TransactionsModel();

            lblTransactionsTotal.Text = $"{ transaction.CountTransactions().ToString() } Transactions";
        }

        public void AccountsBalance()
        {
            AccountsModel a = new AccountsModel();

            lblBalanceTotal.Text = a.AccountBalanceTotal();
        }

        public void Load_Category_Boxes()
        {
            //TODO - THere musst be a better way here
            List<CategoriesModel> categories = new List<CategoriesModel>();

            categories = CategoriesDataProcessor.GetAllCategories();

            if (categories.Count > 0)
            {
                //Shopping Button
                CategoriesModel catShopping = CategoriesDataProcessor.GetAllCategories().Find(x => x.Name == "Shopping");
                Btn_Shopping.Text = $"{ catShopping.Name } \n { GlobalConfig.SetFormat(catShopping.Balance) } { catShopping.Currency }";

                //Family Button
                CategoriesModel catFamily = CategoriesDataProcessor.GetAllCategories().Find(x => x.Name == "Family");
                Btn_Family.Text = $"{ catFamily.Name } \n { GlobalConfig.SetFormat(catFamily.Balance) } { catFamily.Currency }";

                //Salary Button
                CategoriesModel catSalary = CategoriesDataProcessor.GetAllCategories().Find(x => x.Name == "Salary");
                Btn_Salary.Text = $"{ catSalary.Name } \n { GlobalConfig.SetFormat(catSalary.Balance) } { catSalary.Currency }";

                //Transport Button
                CategoriesModel catTransport = CategoriesDataProcessor.GetAllCategories().Find(x => x.Name == "Transport");
                Btn_Transport.Text = $"{ catTransport.Name } \n { GlobalConfig.SetFormat(catTransport.Balance) } { catTransport.Currency }";
            }
            else
            {
                CategoriesDataProcessor.InsertSampleCategories();
                MessageBox.Show("Sample Category Data created");
            }

        }

        private void HOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Refresh Calculations for the Boxes in Dashboard
            AccountsBalance();
            GetNumberOfTransactions();
            GetNumberOfReminders();
            Load_Category_Boxes();

            Panel_Main_Area_Forms.Controls.Clear();
            Panel_Main_Area_Forms.Controls.Add(Main_Home_Controls_groupBox);
            Panel_Main_Area_Forms.BringToFront();
        }

        private void ACCOUNTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close before opening to avoid duplicate of forms
            Accounts.Accounts fc = (Accounts.Accounts)Application.OpenForms["Accounts"];

            if (fc != null)
            {
                fc.Close();
            }

            //Clear Main Area from active or opened forms//
            Panel_Main_Area_Forms.Controls.Clear();

            Accounts.Accounts Acts = new Accounts.Accounts();
            {
                Acts.TopLevel = false;
                Acts.Dock = DockStyle.Fill;
                Panel_Main_Area_Forms.Controls.Add(Acts);
                Acts.Show();
            }
        }

        private void LOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirm_Logout();
        }

        public void USERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close before opening to avoid duplicate of forms
            Users.Users ur = (Users.Users)Application.OpenForms["Users"];

            if (ur != null)
            {
                ur.Close();
            }

            //Clear Main Area from active or opened forms//
            Panel_Main_Area_Forms.Controls.Clear();

            Users.Users usr = new Users.Users();
            {
                usr.TopLevel = false;
                usr.Dock = DockStyle.Fill;
                Panel_Main_Area_Forms.Controls.Add(usr);
                usr.Show();
            }
        }

        private void CATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close before opening to avoid duplicate of forms
            Categories.Categories fc = (Categories.Categories)Application.OpenForms["Categories"];

            if (fc != null)
            {
                fc.Close();
            }

            //Clear from active or opened forms//
            Panel_Main_Area_Forms.Controls.Clear();

            Categories.Categories Categ = new Categories.Categories();
            {
                Categ.TopLevel = false;
                Categ.Dock = DockStyle.Fill;
                Panel_Main_Area_Forms.Controls.Add(Categ);
                Categ.Show();
            }
        }

        private void REMINDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close before opening to avoid duplicate of forms
            Reminder.Reminder rm = (Reminder.Reminder)Application.OpenForms["Reminder"];

            if (rm != null)
            {
                rm.Close();
            }

            //Clear from active or opened forms//
            Panel_Main_Area_Forms.Controls.Clear();

            Reminder.Reminder Rmid = new Reminder.Reminder();
            {
                Rmid.TopLevel = false;
                Rmid.Dock = DockStyle.Fill;
                Panel_Main_Area_Forms.Controls.Add(Rmid);
                Rmid.Show();
            }
        }

        private void REPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear from active or opened forms//
            Panel_Main_Area_Forms.Controls.Clear();

            //Clear from active or opened forms//
            Reports.Reports Rprts = new Reports.Reports();
            {
                Rprts.Dock = DockStyle.Fill;
                Panel_Main_Area_Forms.Controls.Add(Rprts);
                Rprts.Show();
            }
        }

        private void Second_Main_menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "HOME")
            {
                HOMEToolStripMenuItem.BackColor = SelectedColor;
            }
            else
            {
                HOMEToolStripMenuItem.BackColor = Color.SkyBlue;
            }

            if (e.ClickedItem.ToString() == "USERS" || e.ClickedItem.ToString() == "SETTINGS")
            {
                USERSToolStripMenuItem.BackColor = SelectedColor;
            }
            else
            {
                USERSToolStripMenuItem.BackColor = Color.SkyBlue;
            }

            if (e.ClickedItem.ToString() == "ACCOUNTS")
            {
                ACCOUNTSToolStripMenuItem.BackColor = SelectedColor;
            }
            else
            {
                ACCOUNTSToolStripMenuItem.BackColor = Color.SkyBlue;
            }

            if (e.ClickedItem.ToString() == "TRANSACTIONS")
            {
                TransactionsToolStripMenuItem.BackColor = SelectedColor;
            }
            else
            {
                TransactionsToolStripMenuItem.BackColor = Color.SkyBlue;
            }

            if (e.ClickedItem.ToString() == "CATEGORIES")
            {
                CATEGORIESToolStripMenuItem.BackColor = SelectedColor;
            }
            else
            {
                CATEGORIESToolStripMenuItem.BackColor = Color.SkyBlue;
            }

            if (e.ClickedItem.ToString() == "REMINDER")
            {
                REMINDERToolStripMenuItem.BackColor = SelectedColor;
            }
            else
            {
                REMINDERToolStripMenuItem.BackColor = Color.SkyBlue;
            }

            if (e.ClickedItem.ToString() == "REPORTS")
            {
                REPORTSToolStripMenuItem.BackColor = SelectedColor;
            }
            else
            {
                REPORTSToolStripMenuItem.BackColor = Color.SkyBlue;
            }
        }

        private void DashBoardTimer_Tick(object sender, EventArgs e)
        {
            Time_label1.Text = DateTime.Now.ToString("HH:mm:ss"); //Format 22:10:33
        }

        public void TransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close before opening to avoid duplicate of forms
            Transactions.Transactions fc = (Transactions.Transactions)Application.OpenForms["Transactions"];

            if (fc != null)
            {
                fc.Close();
            }

            //Clear from active or opened forms//
            Panel_Main_Area_Forms.Controls.Clear();

            Transactions.Transactions Tra = new Transactions.Transactions();
            {
                Tra.TopLevel = false;
                Tra.Dock = DockStyle.Fill;
                Panel_Main_Area_Forms.Controls.Add(Tra);
                Tra.Show();
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Btn_ViewAll_Transactions_Click(object sender, EventArgs e)
        {
            TransactionsToolStripMenuItem.PerformClick();
        }

        private void LblSettings_Click(object sender, EventArgs e)
        {
            //Clear Dashboard Main Controls
            Panel_Main_Area_Forms.Controls.Clear();
            //Change Home Button Bg
            HOMEToolStripMenuItem.BackColor = Color.SkyBlue;

            RBSettings.RBSettings RSettings = new RBSettings.RBSettings();
            {
                RSettings.Dock = DockStyle.Fill;
                Panel_Main_Area_Forms.Controls.Add(RSettings);
                RSettings.Show();
            }
        }

        private void ImgSettings_Click(object sender, EventArgs e)
        {
            //Clear Dashboard Main Controls
            Panel_Main_Area_Forms.Controls.Clear();
            //Change Home Button Bg
            HOMEToolStripMenuItem.BackColor = Color.SkyBlue;

            RBSettings.RBSettings RSettings = new RBSettings.RBSettings();
            {
                RSettings.Dock = DockStyle.Fill;
                Panel_Main_Area_Forms.Controls.Add(RSettings);
                RSettings.Show();
            }
        }

        private void Btn_OpenNotification_Click(object sender, EventArgs e)
        {
            REMINDERToolStripMenuItem.PerformClick();
        }

        private void Pic_About_Click(object sender, EventArgs e)
        {
            RBSettings.About rba = new RBSettings.About();
            rba.Show();
        }
    }
}