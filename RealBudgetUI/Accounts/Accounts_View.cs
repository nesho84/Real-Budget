using System;
using System.Drawing;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI.Accounts
{
    public partial class Accounts_View : Form
    {
        private readonly AccountsModel account;

        //Instance of the Form Accounts
        private readonly Accounts frmAccounts = null;

        //Define ImageList to get ImageList from Accounts Form
        private readonly ImageList imageList;

        public Accounts_View(Form frm, AccountsModel accm, ImageList imgList)
        {
            //Initialize instance of the Form Accounts
            frmAccounts = frm as Accounts;

            InitializeComponent();

            //Get Accounts Model from Accounts Form
            account = accm;

            //Get ImageList posted from Accounts Form
            imageList = imgList;

            //Fill the Form with passed Data
            LoadFormData();

            txtAccName.Focus();
        }

        private void LoadFormData()
        {
            txtAccName.Text = account.Name;
            Type_comboBox.Text = account.Type;
            txtGoal.Text = account.Goal.ToString();
            txtNotes.Text = account.Notes;
            txtBalance.Text = GlobalConfig.SetFormat(account.Balance);
            txtCreditLimit.Text = account.Limits.ToString();

            if (account.IncludeInTotal == "yes")
            {
                Include_Total_checkBox.Checked = true;
            }
            else
            {
                Include_Total_checkBox.Checked = false;
            }

            Accounts_ViewImage_PicBox.Image = imageList.Images[account.ImageIndex];
            Accounts_ViewImage_PicBox.Image.Tag = account.ImageIndex;
        }

        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtAccName.Text))
            {
                MessageBox.Show("Please enter Account name.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Accounts_ViewImage_PicBox.Image == null)
            {
                MessageBox.Show("Please choose Icon.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Accounts_ViewImage_PicBox.Image = Properties.Resources.NoPic_40px;
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

        private void Edit_Account()
        {
            //Check checkbox Value
            string CheckBoxChecked;

            if (Include_Total_checkBox.Checked == true)
            {
                CheckBoxChecked = "yes";
            }
            else
            {
                CheckBoxChecked = "no";
            }

            //Validate textBoxes
            if (Validation() == true)
            {
                try
                {
                    account.Name = txtAccName.Text;
                    account.Type = Type_comboBox.Text;
                    account.Goal = decimal.Parse(txtGoal.Text);
                    account.Notes = txtNotes.Text;
                    account.Balance = decimal.Parse(txtBalance.Text);
                    account.Limits = decimal.Parse(txtCreditLimit.Text);
                    account.IncludeInTotal = CheckBoxChecked;
                    //Image.Tag as number passed from Accounts_ImagePicker
                    account.ImageIndex = Convert.ToInt32(Accounts_ViewImage_PicBox.Image.Tag);

                    AccountsDataProcessor.UpdateAccount(account);

                    MessageBox.Show($"{Type_comboBox.Text} successfully updated.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Edit_Account();
        }

        private void Btn_ChImage_Click(object sender, EventArgs e)
        {
            Accounts_ImagePicker Acc_ChImg = new Accounts_ImagePicker(this.Name);
            {
                Acc_ChImg.ShowDialog();
            }
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
