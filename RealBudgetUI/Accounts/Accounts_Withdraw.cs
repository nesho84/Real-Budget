using RealBudgetLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealBudgetUI.Accounts
{
    public partial class Accounts_Withdraw : Form
    {
        private readonly AccountsModel account;

        //Instance of the Form Accounts
        private readonly Accounts frmAccounts = null;

        //Check which from top Buttons Selected (Expense or Transfer)
        private string withdrawType;

        public Accounts_Withdraw(Form frm, AccountsModel accm)
        {
            //Initialize instance of the Form Accounts
            frmAccounts = frm as Accounts;

            InitializeComponent();

            //Get Accounts Model from Accounts Form
            account = accm;

            LoadFormData();
        }

        private void LoadFormData()
        {
            //Change Top Header
            lblAccountName.Text = account.Name;
            lblBalance.Text = $"{ GlobalConfig.SetFormat(account.Balance) } {account.Currency}";
            txtCurrency.Text = account.Currency;

            //Start with EXPSENSE Button selected
            Load_Expense();
        }

        private void Load_Expense()
        {
            //Set withdrawType defined above (to know Save button which top button is Selecteed)
            withdrawType = "Expense";

            //Clear Items to avoid Duplicates
            withdrawListBox.DataSource = null;

            //Change selected Button background
            Btn_Transfer.BackColor = SystemColors.Window;
            Btn_Expense.BackColor = SystemColors.ControlLight;

            //Wire up Listbox
            List<CategoriesModel> categories = new List<CategoriesModel>();
            categories = CategoriesDataProcessor.GetAllCategories().FindAll(x => x.Type == "Expenses");
            withdrawListBox.DataSource = categories;
            withdrawListBox.DisplayMember = "Cat_NameBalanceCurrency";

            //From
            lblTitleFrom.Text = "From Account";
            lblFrom.Text = account.Name;
            //To
            lblTitleTo.Text = "To Category";
            lblTo.Text = withdrawListBox.Text;
        }

        private void Load_Transfer()
        {
            //Set withdrawType defined above (to know Save button which top button is Selecteed)
            withdrawType = "Transfer";

            //Clear Items to avoid Duplicates
            withdrawListBox.DataSource = null;

            //Change selected Button background
            Btn_Transfer.BackColor = SystemColors.ControlLight;
            Btn_Expense.BackColor = SystemColors.Window;

            //Excluding the current Account
            List<AccountsModel> accounts = new List<AccountsModel>();
            accounts = AccountsDataProcessor.GetAllAccounts().Where(x => x.Name != account.Name).ToList();
            withdrawListBox.DataSource = accounts;
            withdrawListBox.DisplayMember = "Acc_NameBalanceCurrency";

            //From
            lblTitleFrom.Text = "From Account";
            lblFrom.Text = account.Name;
            //To
            lblTitleTo.Text = "To Account";
            lblTo.Text = withdrawListBox.Text;
        }

        private void Save_Expense()
        {
            try
            {
                //Save to Accounts - Decrease the Balance of the Current Account
                account.Balance -= decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(account);

                //Save to Categories - Increase the Balance of selected Category
                CategoriesModel selectedCategory = (CategoriesModel)withdrawListBox.SelectedItem;
                selectedCategory.Balance += decimal.Parse(txtAmount.Text);
                CategoriesDataProcessor.UpdateCategory(selectedCategory);

                //Save to Transactions 
                TransactionsModel t = new TransactionsModel();
                t.User_Id = GlobalConfig.GetUID();
                t.Type = "Expense";
                t.TFrom = account.Name;
                t.TTo = selectedCategory.Name;
                t.Amount = decimal.Parse(txtAmount.Text);
                t.Notes = RichTxtNotes.Text;
                t.Date_Time = Acc_DateTimePicker.Value.ToString($"dd.MM.yyyy");
                TransactionsDataProcessor.InsertTransaction(t);

                MessageBox.Show($"{account.Name} withdraw completed successfully.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Save_Transfer()
        {
            try
            {
                //Save to Accounts - Decrease the Balance of the Current Account
                account.Balance -= decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(account);

                //Save to Accounts - Decrease the Balance of the Selected Account
                AccountsModel selectedAccount = (AccountsModel)withdrawListBox.SelectedItem;
                selectedAccount.Balance += decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(selectedAccount);

                //Save to Transactions 
                TransactionsModel t = new TransactionsModel();
                t.User_Id = GlobalConfig.GetUID();
                t.Type = "Transfer";
                t.TFrom = account.Name;
                t.TTo = selectedAccount.Name;
                t.Amount = decimal.Parse(txtAmount.Text);
                t.Notes = RichTxtNotes.Text;
                t.Date_Time = Acc_DateTimePicker.Value.ToString($"dd.MM.yyyy");
                TransactionsDataProcessor.InsertTransaction(t);

                MessageBox.Show($"{account.Name} withdraw completed successfully.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Btn_Expense_Click(object sender, EventArgs e)
        {
            Load_Expense();
        }

        private void Btn_Transfer_Click(object sender, EventArgs e)
        {
            Load_Transfer();
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
            if (withdrawType == "Expense")
            {
                Save_Expense();
            }
            if (withdrawType == "Transfer")
            {
                Save_Transfer();
            }
        }

        private void WithdrawListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (withdrawListBox.SelectedIndex > -1)
            {
                lblTo.Text = withdrawListBox.Text;
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
