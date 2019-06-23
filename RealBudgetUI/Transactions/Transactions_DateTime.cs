using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealBudgetUI.Transactions
{
    public partial class Transactions_DateTime : Form
    {
        //Instance of the Form Transactions
        private readonly Transactions transactions = null;

        public Transactions_DateTime(Form form)
        {
            transactions = form as Transactions;

            InitializeComponent();
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            //Just for testing....
            if (transactions != null)
            {
                MessageBox.Show("I am ready to comunicate with Transactions Form", "Just Testing...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
