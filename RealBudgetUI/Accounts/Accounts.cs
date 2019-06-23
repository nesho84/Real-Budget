using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI.Accounts
{
    public partial class Accounts : Form, IAccounts_Balance
    {
        private static AccountsModel account = new AccountsModel();

        public Accounts()
        {
            InitializeComponent();

            Load_Accounts_ListView();
        }

        public void Load_Accounts_ListView()
        {
            try
            {
                AccListView.Items.Clear();

                List<AccountsModel> accounts = new List<AccountsModel>();

                accounts = AccountsDataProcessor.GetAllAccounts();

                foreach (var acc in accounts)
                {
                    ListViewItem lvi = new ListViewItem($"{ acc.Name }\n{ GlobalConfig.SetFormat(acc.Balance) } { acc.Currency }", acc.ImageIndex);
                    lvi.Tag = acc;
                    AccListView.Items.Add(lvi);

                    AccListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Account()
        {
            if (AccListView.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Account?",
                "RealBudget®", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        account = (AccountsModel)AccListView.SelectedItems[0].Tag;

                        AccountsDataProcessor.DeleteAccount(account);

                        MessageBox.Show("Account successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Load_Accounts_ListView();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Select Account", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void View_Edit_Account()
        {
            if (AccListView.SelectedItems.Count > 0)
            {
                account = (AccountsModel)AccListView.SelectedItems[0].Tag;

                Accounts_View frm = new Accounts_View(this, account, this.AccImageList);

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Account", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void View_Balance()
        {
            if (AccListView.SelectedItems.Count > 0)
            {
                account = (AccountsModel)AccListView.SelectedItems[0].Tag;

                Accounts_Balance acsa = new Accounts_Balance(this, account);

                acsa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Account", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void View_Recharge()
        {
            if (AccListView.SelectedItems.Count > 0)
            {
                account = (AccountsModel)AccListView.SelectedItems[0].Tag;

                Accounts_Recharge acsa = new Accounts_Recharge(this, account);

                acsa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Account", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void View_Withdraw()
        {
            if (AccListView.SelectedItems.Count > 0)
            {
                account = (AccountsModel)AccListView.SelectedItems[0].Tag;

                Accounts_Withdraw acsa = new Accounts_Withdraw(this, account);

                acsa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Account", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// This is the implementation of the Interface IAccounts_Balance, used to pass the data to the form Accounts_Balance without knowing...
        /// ...which form hast called it and then get the data back
        /// </summary>
        /// <param name="model"></param>
        public void Accounts_Balance_Complete(AccountsModel model)
        {
            Load_Accounts_ListView();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete_Account();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Accounts_Add Acc_Add = new Accounts_Add(this);
            {
                Acc_Add.ShowDialog();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            View_Edit_Account();
        }

        private void AccListView_DoubleClick(object sender, EventArgs e)
        {
            View_Edit_Account();
        }

        private void Btn_Balance_Click(object sender, EventArgs e)
        {
            View_Balance();
        }

        private void Btn_Recharge_Click(object sender, EventArgs e)
        {
            View_Recharge();
        }

        private void Btn_Withdraw_Click(object sender, EventArgs e)
        {
            View_Withdraw();
        }
    }
}
