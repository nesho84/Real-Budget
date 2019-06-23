using System;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI.Accounts
{
    public partial class Accounts_Balance : Form
    {
        private readonly AccountsModel account;

        //Instance of the Interface that is created so that any form that will call this form is welcome, but with implementing the Interface and passing the model
        private readonly IAccounts_Balance callingForm;

        public Accounts_Balance(IAccounts_Balance caller, AccountsModel model)
        {
            InitializeComponent();

            //Initialize AccountsModel
            account = model;

            //Initialize Interface
            callingForm = caller;

            Load_Balance();
        }

        private void Load_Balance()
        {
            //Change Top Header
            lblAccountName.Text = account.Name;
            lblBalance.Text = $"{GlobalConfig.SetFormat(account.Balance)} {account.Currency}";
            txtAmount.Text = GlobalConfig.SetFormat(account.Balance);
            txtCurrency.Text = account.Currency;
        }

        private void Update_Balance()
        {
            //Validating
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Amount entered is invalid. Please try again.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Text = GlobalConfig.SetFormat(account.Balance);
                return;
            }
            //Saving
            try
            {
                account.Balance = decimal.Parse(txtAmount.Text);
                AccountsDataProcessor.UpdateAccount(account);

                MessageBox.Show($"{this.Text} successfully updated.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong.\nError: {ex.Message}", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                callingForm.Accounts_Balance_Complete(account);
                this.Close();
            }            
        }        

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Update_Balance();
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
