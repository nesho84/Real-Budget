using System;
using System.Collections.Generic;
using System.Linq;

namespace RealBudgetLibrary
{
    public class TransactionsModel
    {
        public int Transaction_Id { get; set; }
        public int User_Id { get; set; }
        public string Type { get; set; }
        public string TFrom { get; set; }
        public string TTo { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string Date_Time { get; set; }

        public int CountTransactions()
        {
            List<TransactionsModel> tra = TransactionsDataProcessor.GetAllTransactions();

            int total = tra.Count();

            return total;
        }
    }
}
