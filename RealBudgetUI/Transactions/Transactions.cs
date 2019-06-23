using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI.Transactions
{
    public partial class Transactions : Form
    {
        private TransactionsModel transaction = new TransactionsModel();

        private List<TransactionsModel> transactions = new List<TransactionsModel>();

        public Transactions()
        {
            InitializeComponent();

            Load_Transactions_ListView();
        }

        public void Load_Transactions_ListView()
        {
            try
            {
                TransListView.Items.Clear();

                transactions = TransactionsDataProcessor.GetAllTransactions().OrderByDescending(x => x.Transaction_Id).ToList();

                foreach (var trans in transactions)
                {
                    //Loading Images from ImageList to the Items
                    int imgIndex = 0;
                    if (trans.Type == "Income") { imgIndex = 1; }
                    if (trans.Type == "Expense") { imgIndex = 2; }
                    if (trans.Type == "Transfer") { imgIndex = 3; }

                    //Loading the ListView
                    ListViewItem lvi = new ListViewItem($"{ trans.Type }", imgIndex);
                    lvi.Tag = trans;
                    TransListView.Items.Add(lvi);
                    lvi.SubItems.Add($"{ GlobalConfig.SetFormat(trans.Amount) } { GlobalConfig.GetUserCurrency() }");
                    lvi.SubItems.Add($"{ trans.Date_Time }");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Load_Transactions_ByDate()
        {
            try
            {
                TransListView.Items.Clear();

                    transactions = TransactionsDataProcessor.GetAllTransactions().OrderByDescending(x => x.Date_Time).
                        Where(x => x.Date_Time == Filter_dateTimePicker.Value.ToString($"dd.MM.yyyy")).ToList();

                foreach (var trans in transactions)
                {
                    int imgIndex = 0;
                    if (trans.Type == "Income") { imgIndex = 1; }
                    if (trans.Type == "Expense") { imgIndex = 2; }
                    if (trans.Type == "Transfer") { imgIndex = 3; }

                    ListViewItem lvi = new ListViewItem($"{ trans.Type }", imgIndex);
                    lvi.Tag = trans;
                    TransListView.Items.Add(lvi);
                    lvi.SubItems.Add($"{ GlobalConfig.SetFormat(trans.Amount) } { GlobalConfig.GetUserCurrency() }");
                    lvi.SubItems.Add($"{ trans.Date_Time }");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void View_Edit_Transaction()
        {
            if (TransListView.SelectedItems.Count > 0)
            {
                transaction = (TransactionsModel)TransListView.SelectedItems[0].Tag;

                Transactions_View frm = new Transactions_View(this, transaction);

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Transaction", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_Transaction()
        {
            if (TransListView.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Transaction?",
                "RealBudget®", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        transaction = (TransactionsModel)TransListView.SelectedItems[0].Tag;

                        TransactionsDataProcessor.DeleteTransaction(transaction);

                        MessageBox.Show("Transaction successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Load_Transactions_ListView();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Select Transaction", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TransListView_DoubleClick(object sender, EventArgs e)
        {
            View_Edit_Transaction();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            View_Edit_Transaction();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete_Transaction();
        }

        private void Btn_DateTime_Click(object sender, EventArgs e)
        {
            Transactions_DateTime trdt = new Transactions_DateTime(this);
            trdt.ShowDialog();
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Transactions_ListView();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //Create New Acount
            Transactions_Add Tra_add = new Transactions_Add(this);
            {
                Tra_add.ShowDialog();
            }
        }

        private void Filter_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Load_Transactions_ByDate();
        }

        private void Btn_NextDate_Click(object sender, EventArgs e)
        {
            Filter_dateTimePicker.Value = Filter_dateTimePicker.Value.AddDays(1);
        }

        private void Btn_PreviousDate_Click(object sender, EventArgs e)
        {
            Filter_dateTimePicker.Value = Filter_dateTimePicker.Value.AddDays(-1);
        }
    }
}
