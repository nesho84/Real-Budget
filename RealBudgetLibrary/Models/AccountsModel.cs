using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RealBudgetLibrary
{
    public class AccountsModel
    {
        public int Account_Id { get; set; }
        public int User_Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public decimal Limits { get; set; }
        public decimal Goal { get; set; }
        public string Notes { get; set; }
        public string IncludeInTotal { get; set; }
        public int ImageIndex { get; set; }

        public string Acc_NameBalanceCurrency
        {
            get
            {
                return $"{ Name }  { GlobalConfig.SetFormat(Balance) } { Currency }";
            }
        }

        public string AccountBalanceTotal()
        {
            List<AccountsModel> acc = AccountsDataProcessor.GetAllAccounts().Where(x => x.IncludeInTotal == "yes").ToList();

            UsersModel usr = UsersDataProcessor.GetByUser_Id(GlobalConfig.GetUID());

            decimal total = acc.Sum(x => x.Balance);

            foreach (AccountsModel a in acc)
            {
                Currency = a.Currency;

                if (a.Currency != null)
                {
                    return $"{ GlobalConfig.SetFormat(total) } { Currency }";
                }
            }

            return $"{ GlobalConfig.SetFormat(total) } { usr.User_Currency }";
        }

    }
}
