using RealBudgetLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RealBudgetUI.Transactions
{
    public partial class Transactions_Add : Form
    {
        //Instance of the Form Accounts
        private readonly Transactions frmTransactions = null;

        private readonly TransactionsModel transaction = new TransactionsModel();

        private readonly List<AccountsModel> accounts = AccountsDataProcessor.GetAllAccounts();

        private readonly List<CategoriesModel> categories = CategoriesDataProcessor.GetAllCategories();

        //Check which from top Buttons Selected (Income, Expense or Transfer) using Enums
        private TransType transactionType;

        public Transactions_Add(Form frm)
        {
            //Initialize instance of the Form Accounts
            frmTransactions = frm as Transactions;

            InitializeComponent();

            LoadFormData();
        }

        private void LoadFormData()
        {
            //Highlight this button
            Btn_Exp.BackColor = Color.LightGray;
            //Change labels From and To
            lblFrom.Text = "From Account";
            lblTo.Text = "To Category";
            //Get UserCurrency
            txtCurrency.Text = GlobalConfig.GetUserCurrency();

            //Start with EXPSENSE Button selected
            Load_Expense();
        }

        private void Load_Income()
        {
            //Set transactionType defined above (to know Btn_Save which button is Selecteed) using Enums
            transactionType = TransType.Income;

            //Highlight buttons which is active
            Btn_Income.BackColor = Color.LightGray;
            Btn_Exp.BackColor = SystemColors.ButtonHighlight;
            Btn_Trans.BackColor = SystemColors.ButtonHighlight;

            //Clear Items to avoid Duplicates
            From_comboBox.DataSource = null;
            To_comboBox.DataSource = null;

            //Wire up DropDown From
            From_comboBox.DataSource = categories.FindAll(x => x.Type == "Income");
            From_comboBox.DisplayMember = "Name";
            lblFrom.Text = "From Category";

            //Wire up DropDown To
            To_comboBox.DataSource = accounts;
            To_comboBox.DisplayMember = "Name";
            lblTo.Text = "To Account";
        }

        private void Load_Expense()
        {
            //Set transactionType defined above (to know Btn_Save which top button is Selecteed) using Enums
            transactionType = TransType.Expense;

            //Highlight buttons which is active
            Btn_Exp.BackColor = Color.LightGray;
            Btn_Trans.BackColor = SystemColors.ButtonHighlight;
            Btn_Income.BackColor = SystemColors.ButtonHighlight;

            //Clear Items to avoid Duplicates
            From_comboBox.DataSource = null;
            To_comboBox.DataSource = null; ;

            //Wire up DropDown From
            From_comboBox.DataSource = accounts;
            From_comboBox.DisplayMember = "Name";
            lblFrom.Text = "From Account";

            //Wire up DropDown To
            To_comboBox.DataSource = categories.FindAll(x => x.Type == "Expenses");
            To_comboBox.DisplayMember = "Name";
            lblTo.Text = "To Category";
        }

        private void Load_Transfer()
        {
            //Set transactionType defined above (to know Btn_Save which top button is Selecteed) using Enums
            transactionType = TransType.Transfer;

            Btn_Trans.BackColor = Color.LightGray;
            Btn_Income.BackColor = SystemColors.ButtonHighlight;
            Btn_Exp.BackColor = SystemColors.ButtonHighlight;

            //Clear Items to avoid Duplicates
            From_comboBox.DataSource = null;
            To_comboBox.DataSource = null;

            //Wire up DropDown From
            From_comboBox.DataSource = accounts;
            From_comboBox.DisplayMember = "Name";
            lblFrom.Text = "From Account";

            //Wire up DropDown To
            To_comboBox.DataSource = accounts.FindAll(x => x.Name != From_comboBox.Text);
            To_comboBox.DisplayMember = "Name";
            lblTo.Text = "To Account";
        }

        private void Save_Income()
        {
            try
            {
                //Save to Categories - Increase the Balance of the Income Category (ex. Salary)
                CategoriesModel selectedCatFrom = (CategoriesModel)From_comboBox.SelectedItem;
                selectedCatFrom.Balance += decimal.Parse(txtAmount.Text);
                CategoriesDataProcessor.UpdateCategory(selectedCatFrom);

                //Save to Accounts - Increase the Balance
                AccountsModel selectedAccTo = (AccountsModel)To_comboBox.SelectedItem;
                selectedAccTo.Balance += decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(selectedAccTo);

                //Save to Transactions 
                transaction.User_Id = GlobalConfig.GetUID();
                transaction.Type = "Income";
                transaction.TFrom = selectedCatFrom.Name;
                transaction.TTo = selectedAccTo.Name;
                transaction.Amount = decimal.Parse(txtAmount.Text);
                transaction.Notes = RichTxtNotes.Text;
                transaction.Date_Time = Trans_DateTimePicker.Value.ToString($"dd.MM.yyyy");
                TransactionsDataProcessor.InsertTransaction(transaction);

                MessageBox.Show($"Expense saved successfully.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();

                this.frmTransactions.Load_Transactions_ListView();
            }
        }

        private void Save_Expense()
        {
            try
            {
                //Save to Accounts - Decrease the Balance
                AccountsModel selectedAccFrom = (AccountsModel)From_comboBox.SelectedItem;
                selectedAccFrom.Balance -= decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(selectedAccFrom);

                //Save to Categories - Increase the Balance
                CategoriesModel selectedCatTo = (CategoriesModel)To_comboBox.SelectedItem;
                selectedCatTo.Balance += decimal.Parse(txtAmount.Text);
                CategoriesDataProcessor.UpdateCategory(selectedCatTo);

                //Save to Transactions 
                transaction.User_Id = GlobalConfig.GetUID();
                transaction.Type = "Expense";
                transaction.TFrom = selectedAccFrom.Name;
                transaction.TTo = selectedCatTo.Name;
                transaction.Amount = decimal.Parse(txtAmount.Text);
                transaction.Notes = RichTxtNotes.Text;
                transaction.Date_Time = Trans_DateTimePicker.Value.ToString($"dd.MM.yyyy");
                TransactionsDataProcessor.InsertTransaction(transaction);

                MessageBox.Show($"Expense saved successfully.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();

                this.frmTransactions.Load_Transactions_ListView();
            }
        }        

        private void Save_Transfer()
        {
            try
            {
                //Save to Accounts - Decrease the Balance of the current Account
                AccountsModel selectedAccFrom = (AccountsModel)From_comboBox.SelectedItem;
                selectedAccFrom.Balance -= decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(selectedAccFrom);

                //Save to Accounts - Increase the Balance of the target Account
                AccountsModel selectedAccTo = (AccountsModel)To_comboBox.SelectedItem;
                selectedAccTo.Balance += decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(selectedAccTo);

                //Save to Transactions 
                transaction.User_Id = GlobalConfig.GetUID();
                transaction.Type = "Transfer";
                transaction.TFrom = selectedAccFrom.Name;
                transaction.TTo = selectedAccTo.Name;
                transaction.Amount = decimal.Parse(txtAmount.Text);
                transaction.Notes = RichTxtNotes.Text;
                transaction.Date_Time = Trans_DateTimePicker.Value.ToString($"dd.MM.yyyy");
                TransactionsDataProcessor.InsertTransaction(transaction);

                MessageBox.Show($"Transfer completed successfully.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();

                this.frmTransactions.Load_Transactions_ListView();
            }
        }

        private void Btn_Income_Click(object sender, EventArgs e)
        {
            Load_Income();
        }

        private void Btn_Exp_Click(object sender, EventArgs e)
        {
            Load_Expense();
        }

        private void Btn_Trans_Click(object sender, EventArgs e)
        {
            Load_Transfer();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (transactionType == TransType.Income)
            {
                Save_Income();
            }
            if (transactionType == TransType.Expense)
            {
                Save_Expense();
            }
            if (transactionType == TransType.Transfer)
            {
                Save_Transfer();
            }
        }

        private void RichTxtNotes_TextChanged(object sender, EventArgs e)
        {
            //Calculating the number of characters and display in the Label
            int TextCaracCounter = RichTxtNotes.MaxLength - RichTxtNotes.Text.Length;

            lblRichTextBoxTitle.Text = TextCaracCounter.ToString() + " Character{s) remaining [100 maximum]";
        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow the user to enter Just numbers or decimals (keypress event of the textbox)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one - point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void From_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (From_comboBox.SelectedIndex > -1)
            {
                if (transactionType == TransType.Income)
                {
                    CategoriesModel catm = (CategoriesModel)From_comboBox.SelectedItem;
                    lblFrom.Text = $"From Category \n{ catm.Name } { GlobalConfig.SetFormat(catm.Balance) } { catm.Currency }";
                }
                if (transactionType == TransType.Expense)
                {
                    AccountsModel accm = (AccountsModel)From_comboBox.SelectedItem;
                    lblFrom.Text = $"From Account \n{ accm.Name } { GlobalConfig.SetFormat(accm.Balance) } { accm.Currency }";
                }
                if (transactionType == TransType.Transfer)
                {
                    //Hidding the selectedFrom Account so that current account cannot transfer to its own
                    To_comboBox.DataSource = accounts.FindAll(x => x.Name != From_comboBox.Text);

                    AccountsModel accm = (AccountsModel)From_comboBox.SelectedItem;
                    lblFrom.Text = $"From Account \n{ accm.Name } { GlobalConfig.SetFormat(accm.Balance) } { accm.Currency }";
                }
            }
        }

        private void To_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (To_comboBox.SelectedIndex > -1)
            {
                if (transactionType == TransType.Income)
                {
                    AccountsModel accm = (AccountsModel)To_comboBox.SelectedItem;
                    lblTo.Text = $"To Account \n{ accm.Name } { GlobalConfig.SetFormat(accm.Balance) } { accm.Currency }";
                }
                if (transactionType == TransType.Expense)
                {
                    CategoriesModel catm = (CategoriesModel)To_comboBox.SelectedItem;
                    lblTo.Text = $"From Category \n{ catm.Name } { GlobalConfig.SetFormat(catm.Balance) } { catm.Currency }";
                }
                if (transactionType == TransType.Transfer)
                {
                    AccountsModel accm = (AccountsModel)To_comboBox.SelectedItem;
                    lblTo.Text = $"To Account \n{ accm.Name } { GlobalConfig.SetFormat(accm.Balance) } { accm.Currency }";
                }
            }
        }

        private void TxtAmount_Leave(object sender, EventArgs e)
        {
            decimal.TryParse(txtAmount.Text, out decimal d);

            if (d > 0)
            {
                txtAmount.Text = d.ToString("N2");
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                txtAmount.Text = d.ToString("N2");
            }
        }
    }
}
