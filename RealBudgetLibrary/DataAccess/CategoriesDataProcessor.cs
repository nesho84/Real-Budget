using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace RealBudgetLibrary
{
    public static class CategoriesDataProcessor
    {
        //Identifies the User_Id stored in App.config, this will be updated every time a user logedin
        private static readonly int User_Id = GlobalConfig.GetUID();
        //Identifies the UserCurrency stored in App.config, this will be updated every time a user logedin
        private static readonly string UserCurrency = GlobalConfig.GetUserCurrency();


        /// <summary>
        /// Getting All records from database
        /// </summary>
        /// <returns></returns>
        public static List<CategoriesModel> GetAllCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                return cnn.Query<CategoriesModel>("Select * From tbl_Categories WHERE User_Id = @User_Id", new { User_Id }).ToList();
            }
        }

        /// <summary>
        /// Insert into database
        /// </summary>
        /// <param name="categoriesModel"></param>
        public static void InsertCategory(CategoriesModel categoriesModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("insert into tbl_Categories (User_Id, Name, Type, Currency, ImageIndex) values " +
                    "(@User_Id, @Name, @Type, @Currency, @ImageIndex)", categoriesModel);
            }
        }

        /// <summary>
        /// Update record in database
        /// </summary>
        /// <param name="Cat_Id"></param>
        public static void UpdateCategory(CategoriesModel Cat_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("update tbl_Categories set Name=@Name, Type=@Type, Balance=@Balance, Currency=@Currency, ImageIndex=@ImageIndex where Cat_Id = @Cat_Id", Cat_Id);
            }
        }

        /// <summary>
        /// Delete record in database
        /// </summary>
        /// <param name="Cat_Id"></param>
        public static void DeleteCategory(CategoriesModel Cat_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("delete from tbl_Categories where Cat_Id = @Cat_Id", Cat_Id);
            }
        }

        /// <summary>
        /// Insert multipe rows or List of object into database
        /// </summary>
        /// <param name="listCategoriesModel"></param>
        public static void InsertSampleCategories()
        {
            List<CategoriesModel> listCategoriesModel = new List<CategoriesModel>{
                new CategoriesModel { User_Id = User_Id, Name = "Family", Type = "Expenses", Balance = 0, Currency = UserCurrency, ImageIndex = 1 },
                new CategoriesModel { User_Id = User_Id, Name = "Transport", Type = "Expenses", Balance = 0, Currency = UserCurrency, ImageIndex = 2 },
                new CategoriesModel { User_Id = User_Id, Name = "Shopping", Type = "Expenses", Balance = 0, Currency = UserCurrency, ImageIndex = 3 },
                new CategoriesModel { User_Id = User_Id, Name = "Salary", Type = "Income", Balance = 0, Currency = UserCurrency, ImageIndex = 4 },
                new CategoriesModel { User_Id = User_Id, Name = "Gifts", Type = "Expenses", Balance = 0, Currency = UserCurrency, ImageIndex = 5 },
                new CategoriesModel { User_Id = User_Id, Name = "Restaurant", Type = "Expenses", Balance = 0, Currency = UserCurrency, ImageIndex = 6 }
            };

            foreach (var item in listCategoriesModel)
            {
                using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
                {
                    cnn.Execute("insert into tbl_Categories (User_Id, Name, Type, Currency, ImageIndex) values " +
                        "(@User_Id, @Name, @Type, @Currency, @ImageIndex)", item);
                }
            }
        }
    }
}
