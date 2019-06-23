using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace RealBudgetLibrary
{
    public static class TransactionsDataProcessor
    {
        //Identifies the User_Id stored in App.config, this will be updated every time a user logedin
        private static readonly int User_Id = GlobalConfig.GetUID();

        /// <summary>
        /// Getting All records from database
        /// </summary>
        public static List<TransactionsModel> GetAllTransactions()
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                return cnn.Query<TransactionsModel>("Select * From tbl_Transactions WHERE User_Id = @User_Id", new { User_Id }).ToList();
            }
        }

        /// <summary>
        /// Insert into database
        /// </summary>
        /// <param name="transactionsModel"></param>
        public static void InsertTransaction(TransactionsModel transactionsModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("Insert Into tbl_Transactions (User_Id, Type, TFrom, TTo, Amount, Notes, Date_Time) values " +
                    "(@User_Id, @Type, @TFrom, @TTo, @Amount, @Notes, @Date_Time)", transactionsModel);
            }
        }

        /// <summary>
        /// Update record in database
        /// </summary>
        /// <param name="Transaction_Id"></param>
        public static void UpdateTransaction(TransactionsModel Transaction_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("update tbl_Transactions set Type=@Type, TFrom=@TFrom, TTo=@TTo, Amount=@Amount, Notes=@Notes, Date_Time=@Date_Time where Transaction_Id = @Transaction_Id", Transaction_Id);
            }
        }

        /// <summary>
        /// Delete record in database
        /// </summary>
        /// <param name="Transaction_Id"></param>
        public static void DeleteTransaction(TransactionsModel Transaction_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("delete from tbl_Transactions where Transaction_Id = @Transaction_Id", Transaction_Id);
            }
        }
    }
}
