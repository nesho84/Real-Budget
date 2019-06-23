using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace RealBudgetLibrary
{
    public static class AccountsDataProcessor
    {
        //Identifies the User_Id stored in App.config, this will be updated every time a user logedin
        private static readonly int User_Id = GlobalConfig.GetUID();

        /// <summary>
        /// Getting All records from database
        /// </summary>
        public static List<AccountsModel> GetAllAccounts()
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                return cnn.Query<AccountsModel>("Select * From tbl_Accounts WHERE User_Id = @User_Id", new { User_Id }).ToList();
            }
        }

        /// <summary>
        /// Insert into database
        /// </summary>
        /// <param name="accountsModel"></param>
        public static void InsertAccount(AccountsModel accountsModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("insert into tbl_Accounts (User_Id, Name, Type, Goal, Notes, Balance, Currency, Limits, IncludeInTotal, ImageIndex) values " +
                    "(@User_Id, @Name, @Type, @Goal, @Notes, @Balance, @Currency, @Limits, @IncludeInTotal, @ImageIndex)", accountsModel);
            }
        }

        /// <summary>
        /// Update record in database
        /// </summary>
        /// <param name="Account_Id"></param>
        public static void UpdateAccount(AccountsModel Account_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("update tbl_Accounts set Name=@Name, Type=@Type, Goal=@Goal, Notes=@Notes, Balance=@Balance, Currency=@Currency, Limits=@Limits, IncludeInTotal=@IncludeInTotal, ImageIndex=@ImageIndex where Account_Id=@Account_Id", Account_Id);
            }
        }

        /// <summary>
        /// Delete record in database
        /// </summary>
        /// <param name="Account_Id"></param>
        public static void DeleteAccount(AccountsModel Account_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("delete from tbl_Accounts where Account_Id = @Account_Id", Account_Id);
            }
        }
    }
}
