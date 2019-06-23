using RealBudgetLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RealBudgetUI.Transactions
{
    public partial class Transactions_View : Form
    {
        private readonly TransactionsModel transaction;

        //Instance of the Form Transactions
        private readonly Transactions frmTransactions = null;
        
        public Transactions_View(Form frm, TransactionsModel tram)
        {
            //Initialize instance of the Form Accounts
            frmTransactions = frm as Transactions;

            InitializeComponent();

            //Get AccountsModel from Accounts Form
            transaction = tram;

            LoadFormData();
        }

        private void LoadFormData()
        {
            //Change Top Header - Amount and Currency
            lblTransType.Text = transaction.Type;
            lblAmount.Text = $"{ GlobalConfig.SetFormat(transaction.Amount) } { GlobalConfig.GetUserCurrency() }";

            //Change From and To labels
            if (transaction.Type == "Income")
            {
                lblFrom.Text = $"From Category\n{ transaction.TFrom }";
                lblTo.Text = $"To Account\n{ transaction.TTo }";
            }
            if (transaction.Type == "Expense")
            {
                lblFrom.Text = $"From Account\n{ transaction.TFrom }";
                lblTo.Text = $"To Category\n{ transaction.TTo }";
            }
            if (transaction.Type == "Transfer")
            {
                lblFrom.Text = $"From Account\n{ transaction.TFrom }";
                lblTo.Text = $"To Account\n{ transaction.TTo }";
            }

            //RichTextBox Notes
            RichTxtNotes.Text = transaction.Notes;
            //DateTimePicker
            Trans_DateTimePicker.Text = transaction.Date_Time.ToString();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Update_Transaction();
        }

        public void Update_Transaction()
        {
            try
            {
                transaction.Notes = RichTxtNotes.Text;
                TransactionsDataProcessor.UpdateTransaction(transaction);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong.\nError: {ex.Message}", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.Close();
                this.frmTransactions.Load_Transactions_ListView();
            }
        }

        private void RichTxtNotes_TextChanged(object sender, EventArgs e)
        {
            //Calculating the number of characters and display in the Label
            int TextCaracCounter = RichTxtNotes.MaxLength - RichTxtNotes.Text.Length;

            lblRichTextBoxTitle.Text = TextCaracCounter.ToString() + " Character{s) remaining [100 maximum]";
        }
    }
}
