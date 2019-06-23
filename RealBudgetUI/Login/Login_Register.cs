﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using RealBudgetLibrary;

namespace RealBudgetUI.Login
{
    public partial class Login_Register : Form
    {
        public Login_Register()
        {
            InitializeComponent();

            LoadFormData();
        }

        private void LoadFormData()
        {
            if (Currency_comboBox.Items.Count > 0)
            {
                Currency_comboBox.SelectedIndex = 0;
            }
        }

        private bool User_Exists()
        {            
            try
            {
                int cntUserNames = UsersDataProcessor.GetAllUsers().FindAll(x => x.Username == TxtUsername.Text).Count;

                if (cntUserNames > 0)
                {
                    TxtUsername.BackColor = Color.Tomato;
                    MessageBox.Show("This Username already taken!", "RealBudget®", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                return true;
            }
        }

        private bool Validate_TextBoxes()
        {
            Regex RX = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (!RX.IsMatch(TxtEmail.Text))
            {
                TxtEmail.BackColor = Color.Tomato;
                MessageBox.Show("Invalid Email Format!", "RealBudget®", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                TxtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtUsername.Text))
            {
                TxtUsername.BackColor = Color.Tomato;
                MessageBox.Show("Please insert Username.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtPass.Text))
            {
                TxtPass.BackColor = Color.Tomato;
                MessageBox.Show("Please enter Password.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                TxtPass.Focus();
                return false;
            }
            if (TxtPass2.Text != TxtPass.Text)
            {
                TxtPass2.BackColor = Color.Tomato;
                MessageBox.Show("Confirmation Failed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                TxtPass2.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Save_User()
        {
            if (Validate_TextBoxes() == true && User_Exists() == false)
            {
                try
                {
                    UsersModel user = new UsersModel();

                    user.Username = TxtUsername.Text;
                    user.Password = TxtPass.Text;
                    user.Email = TxtEmail.Text;
                    user.User_Currency = Currency_comboBox.Text;
                    user.Access_Role = "user";
                    user.Blocked = "no";
                    //Generate random imageIndex
                    Random rnd = new Random();
                    int randomIndex = rnd.Next(5);
                    user.ImageIndex = GetRandom(0, 4);

                    UsersDataProcessor.InsertUser(user);

                    MessageBox.Show("Registration completed successfully.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private int GetRandom(int nrMin, int nrMax)
        {
            Random rnd = new Random();
            return rnd.Next(nrMin, nrMax);
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            if (TxtEmail.TextLength > 0)
            {
                TxtEmail.BackColor = SystemColors.Window;
            }
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsername.TextLength > 0)
            {
                TxtUsername.BackColor = SystemColors.Window;
            }
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            if (TxtPass.TextLength > 0)
            {
                TxtPass.BackColor = SystemColors.Window;
            }
        }

        private void TxtPass2_TextChanged(object sender, EventArgs e)
        {
            if (TxtPass2.TextLength > 0)
            {
                TxtPass2.BackColor = SystemColors.Window;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save_User();
        }
    }
}
