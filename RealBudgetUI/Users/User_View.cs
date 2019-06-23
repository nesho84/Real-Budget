using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI.Users
{
    public partial class User_View : Form
    {
        //Define varaiable for UsersModel
        private UsersModel user;

        //Instance of the Form Users_List
        private readonly Users frmUsers = null;

        public User_View(Form form, UsersModel usr)
        {
            frmUsers = form as Users;

            InitializeComponent();

            //Get UsersModel from Users_List Form
            user = usr;

            LoadFormData();
        }

        private void LoadFormData()
        {
            if (user.Access_Role == "admin")
            {
                this.Text = "Edit Admin";
                TxtUsername.Enabled = false;
                Access_comboBox.Enabled = false;
            }

            //Get data From UsersModel Class
            TxtUsername.Text = user.Username;
            TxtPass.Text = user.Password;
            TxtEmail.Text = user.Email;
            Currency_comboBox.Text = user.User_Currency;
            Access_comboBox.Text = user.Access_Role;
        }

        private void UpdateUser()
        {
            if (Validate_TextBoxes() == true && User_Exists() == false)
            {
                try
                {
                    //Store data in UsersModel Class
                    user.Username = TxtUsername.Text;
                    user.Password = TxtPass.Text;
                    user.Email = TxtEmail.Text;
                    user.User_Currency = Currency_comboBox.SelectedItem.ToString();
                    user.Access_Role = Access_comboBox.SelectedItem.ToString();

                    //Save data to SQLite
                    UsersDataProcessor.UpdateUser(user);

                    MessageBox.Show("Update completed successfully.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Close();
                    //Refresh the Parent Form
                    this.frmUsers.Load_Users_LisView();
                }
            }
        }

        private bool User_Exists()
        {
            try
            {
                user = UsersDataProcessor.GetAllUsers().Find(x => x.User_Id == user.User_Id);

                //Getting all users except this we are updating, to avoid Username duplicates
                int cntUserNames = UsersDataProcessor.GetAllUsers().FindAll(x => x.Username == TxtUsername.Text && x.Username != user.Username).Count;

                if (cntUserNames > 0)
                {
                    TxtUsername.BackColor = Color.Tomato;
                    MessageBox.Show("This Username already taken.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtUsername.Focus();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool Validate_TextBoxes()
        {
            //Email validation with Regex
            Regex RX = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (!RX.IsMatch(TxtEmail.Text))
            {
                TxtEmail.BackColor = Color.Tomato;
                MessageBox.Show("Invalid Email Format!", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.Focus();
                return false;
            }
            else if (TxtUsername.TextLength == 0)
            {
                TxtUsername.BackColor = Color.Tomato;
                MessageBox.Show("Please enter Username.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsername.Focus();
                return false;
            }
            if (TxtPass.TextLength == 0)
            {
                TxtPass.BackColor = Color.Tomato;
                MessageBox.Show("Please enter Password.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPass.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }
    }
}
