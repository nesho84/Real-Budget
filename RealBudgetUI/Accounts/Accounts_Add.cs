using System;
using System.Drawing;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI.Accounts
{
    public partial class Accounts_Add : Form
    {
        //Instance of the Form
        private readonly Accounts frmAccounts = null;

        public Accounts_Add(Form frm)
        {
            frmAccounts = frm as Accounts;

            InitializeComponent();

            //At form start
            Type_comboBox.SelectedIndex = 0;
            txtAccName.Focus();
        }

        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtAccName.Text))
            {
                MessageBox.Show("Please enter Account name.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Accounts_AddImage_PicBox.Image == null)
            {
                MessageBox.Show("Please choose Icon.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Accounts_AddImage_PicBox.Image = Properties.Resources.NoPic_40px;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGoal.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtGoal.Text, $"[^0-9.,]"))
            {
                this.txtGoal.Focus();
                txtGoal.BackColor = Color.Tomato;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBalance.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtBalance.Text, $"[^0-9.,]"))
            {
                this.txtBalance.Focus();
                txtBalance.BackColor = Color.Tomato;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCreditLimit.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtCreditLimit.Text, $"[^0-9.,]"))
            {
                this.txtCreditLimit.Focus();
                txtCreditLimit.BackColor = Color.Tomato;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Save_Account()
        {
            //Check checkbox Value
            string CheckBoxChecked;

            if (Include_Total_checkBox1.Checked == true)
            {
                CheckBoxChecked = "yes";
            }
            else
            {
                CheckBoxChecked = "no";
            }

            if (Validation())
            {
                try
                {
                    AccountsModel account = new AccountsModel();

                    account.User_Id = GlobalConfig.GetUID();
                    account.Name = txtAccName.Text;
                    account.Type = Type_comboBox.Text;
                    account.Goal = decimal.Parse(txtGoal.Text);
                    account.Notes = txtNotes.Text;
                    account.Balance = decimal.Parse(txtBalance.Text);
                    account.Currency = GlobalConfig.GetUserCurrency();
                    account.Limits = decimal.Parse(txtCreditLimit.Text);
                    account.IncludeInTotal = CheckBoxChecked;
                    //Image.Tag as number passed from Accounts_ImagePicker
                    account.ImageIndex = Convert.ToInt32(Accounts_AddImage_PicBox.Image.Tag);

                    AccountsDataProcessor.InsertAccount(account);

                    MessageBox.Show($"{ account.Type } successfully created.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong.\nError: {ex.Message}", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    this.Close();
                    this.frmAccounts.Load_Accounts_ListView();
                }
            }
            else
            {
                return;
            }
        }

        private void Btn_ChImage_Click(object sender, EventArgs e)
        {
            Accounts_ImagePicker Acc_ChImg = new Accounts_ImagePicker(this.Name);
            {
                Acc_ChImg.ShowDialog();
            }
        }

        public void Btn_Save_Click(object sender, EventArgs e)
        {
            Save_Account();
        }

        private void TxtBalance_Leave(object sender, EventArgs e)
        {
            decimal.TryParse(txtBalance.Text, out decimal d);

            if (d > 0)
            {
                txtBalance.Text = d.ToString("N2");
            }
        }
    }
}
