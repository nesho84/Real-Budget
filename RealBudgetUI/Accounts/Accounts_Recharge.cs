using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI.Accounts
{
    public partial class Accounts_Recharge : Form
    {
        private readonly AccountsModel account;

        //Instance of the Form Accounts
        private readonly Accounts frmAccounts = null;

        //Check which from top Buttons Selected (Income or From Account)
        private string rechargeType;

        public Accounts_Recharge(Form frm, AccountsModel accm)
        {
            //Initialize instance of the Form Accounts
            frmAccounts = frm as Accounts;

            InitializeComponent();

            //Get AccountsModel from Accounts Form
            account = accm;

            LoadFormData();
        }

        private void LoadFormData()
        {
            //Change Top Header
            lblAccountName.Text = account.Name;
            lblBalance.Text = $"{ GlobalConfig.SetFormat(account.Balance) } { account.Currency }";            
            txtCurrency.Text = account.Currency;

            //Start with Income Button selected
            Load_Income();
        }

        private void Load_Income()
        {
            //Set rechargeType defined above (to know Save button which top button is Selecteed)
            rechargeType = "Income";

            //Clear Items to avoid Duplicates
            chargeListBox.DataSource = null;

            //Change selected Button background
            Btn_FromAccount.BackColor = SystemColors.Window;
            Btn_Income.BackColor = SystemColors.ControlLight;

            //Wire up Listbox
            List<CategoriesModel> categories = new List<CategoriesModel>();
            categories = CategoriesDataProcessor.GetAllCategories().FindAll(x => x.Type == "Income");
            chargeListBox.DataSource = categories;
            chargeListBox.DisplayMember = "Cat_NameBalanceCurrency";

            //From
            lblTitleFrom.Text = "From Caregory";
            lblFrom.Text = chargeListBox.Text;
            //To
            lblTitleTo.Text = "To Account";
            lblTo.Text = account.Name;
        }

        private void Load_From_Account()
        {
            //Set rechargeType defined above (to know Save button which top button is Selecteed)
            rechargeType = "From Account";

            //Clear Items to avoid Duplicates
            chargeListBox.DataSource = null;

            Btn_Income.BackColor = SystemColors.Window;
            Btn_FromAccount.BackColor = SystemColors.ControlLight;

            //Excluding the current Account
            List<AccountsModel> accounts = new List<AccountsModel>();
            accounts = AccountsDataProcessor.GetAllAccounts().Where(x => x.Name != account.Name).ToList();
            chargeListBox.DataSource = accounts;
            chargeListBox.DisplayMember = "Acc_NameBalanceCurrency";

            //From
            lblTitleFrom.Text = "From Account";
            lblFrom.Text = chargeListBox.Text;
            //To
            lblTitleTo.Text = "To Account";
            lblTo.Text = account.Name;
        }

        private void Save_Income()
        {
            try
            {
                //Save to Categories - Increase the Balance of the Income Category (ex. Salary)
                CategoriesModel selectedCategory = (CategoriesModel)chargeListBox.SelectedItem;
                selectedCategory.Balance += decimal.Parse(txtAmount.Text);
                CategoriesDataProcessor.UpdateCategory(selectedCategory);

                //Save to Accounts - Increase the Balance of the Current Account
                account.Balance += decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(account);

                //Save to Transactions 
                TransactionsModel t = new TransactionsModel();
                t.User_Id = GlobalConfig.GetUID();
                t.Type = "Income";
                t.TFrom = selectedCategory.Name;
                t.TTo = account.Name;
                t.Amount = decimal.Parse(txtAmount.Text);
                t.Notes = RichTxtNotes.Text;
                t.Date_Time = Acc_DateTimePicker.Value.ToString($"dd.MM.yyyy");
                TransactionsDataProcessor.InsertTransaction(t);

                MessageBox.Show($"{account.Name} successfully recharged.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Save_From_Account()
        {
            try
            {
                AccountsModel selectedAccount = (AccountsModel)chargeListBox.SelectedItem;

                //Save to Accounts - Decrease the Balance of the current Account
                selectedAccount.Balance -= decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(selectedAccount);

                //Save to Accounts - Increase the Balance of the target Account
                account.Balance += decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(account);

                //Save to Transactions 
                TransactionsModel t = new TransactionsModel();
                t.User_Id = GlobalConfig.GetUID();
                t.Type = "Transfer";
                t.TFrom = selectedAccount.Name;
                t.TTo = account.Name;
                t.Amount = decimal.Parse(txtAmount.Text);
                t.Notes = RichTxtNotes.Text;
                t.Date_Time = Acc_DateTimePicker.Value.ToString($"dd.MM.yyyy HH:mm:ss");
                TransactionsDataProcessor.InsertTransaction(t);

                MessageBox.Show($"{account.Name} successfully recharged.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Btn_Income_Click(object sender, EventArgs e)
        {
            Load_Income();
        }

        private void Btn_FromAccount_Click(object sender, EventArgs e)
        {
            Load_From_Account();
        }

        private void ChargeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chargeListBox.SelectedIndex > -1)
            {
                lblFrom.Text = chargeListBox.Text;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //Validating
            if (string.IsNullOrWhiteSpace(txtAmount.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text, $"[^0-9.,]"))
            {
                MessageBox.Show("Amount entered is invalid. Please try again.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtAmount.Focus();
                return;
            }
            //Saving
            if (rechargeType == "Income")
            {
                Save_Income();
            }
            if (rechargeType == "From Account")
            {
                Save_From_Account();
            }
        }

        private void RichTxtNotes_TextChanged(object sender, EventArgs e)
        {
            //Calculating the number of characters and display in the Label
            int TextCaracCounter = RichTxtNotes.MaxLength - RichTxtNotes.Text.Length;

            lblRichTextBoxTitle.Text = TextCaracCounter.ToString() + " Character{s) remaining [100 maximum]";
        }

        private void TxtAmount_Leave(object sender, EventArgs e)
        {
            decimal.TryParse(txtAmount.Text, out decimal d);

            if (d > 0)
            {
                txtAmount.Text = d.ToString("N2");
            }
        }
    }
}
