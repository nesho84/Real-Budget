using System;
using System.Collections.Generic;
using System.Linq;

namespace RealBudgetLibrary
{
    public class CategoriesModel
    {
        public int Cat_Id { get; set; }
        public int User_Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public int ImageIndex { get; set; }

        public decimal GetTotalOfExpenses(List<CategoriesModel> listCategories)
        {
            decimal total = listCategories.Where(x => x.Type == "Expenses").Sum(x => x.Balance);

            return total;
        }

        public decimal GetTotalOfIncome(List<CategoriesModel> listCategories)
        {
            return listCategories.Where(x => x.Type == "Income").Sum(x => x.Balance);
        }

        public string Cat_NameBalanceCurrency
        {
            get
            {
                return $"{Name}  { GlobalConfig.SetFormat(Balance) } { Currency }";
            }
        }
    }
}
