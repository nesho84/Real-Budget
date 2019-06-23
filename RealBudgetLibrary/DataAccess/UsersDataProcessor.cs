using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace RealBudgetLibrary
{
    public static class UsersDataProcessor
    {
        /// <summary>
        /// GAll Users from database
        /// </summary>
        /// <returns></returns>
        public static List<UsersModel> GetAllUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                return cnn.Query<UsersModel>($"select * from tbl_Users", new DynamicParameters()).ToList();
            }
        }

        /// <summary>
        /// Get User data from database using User_Id
        /// </summary>
        /// <param name="User_Id">using User_Id</param>
        /// <returns></returns>
        public static UsersModel GetByUser_Id(int User_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                return cnn.Query<UsersModel>($"Select * From tbl_Users WHERE User_Id = @User_Id", new { User_Id }).SingleOrDefault();
            }
        }

        /// <summary>
        /// Insert into database
        /// </summary>
        /// <param name="usersModel"></param>
        /// <returns></returns>
        public static UsersModel InsertUser(UsersModel usersModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("insert into tbl_Users (Username, Password, Email, User_Currency, " +
                        "Access_Role, Blocked) values (@Username, @Password, @Email, @User_Currency, " +
                        "@Access_Role, @Blocked)", usersModel);

                return usersModel;
            }
        }

        /// <summary>
        /// Update record in database
        /// </summary>
        /// <param name="User_Id"></param>
        public static void UpdateUser(UsersModel User_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("update tbl_Users set Username=@Username, Password=@Password, Email=@Email, User_Currency=@User_Currency, " +
                        "Access_Role=@Access_Role, Blocked=@Blocked where User_Id=@User_Id", User_Id);
            }
        }

        /// <summary>
        /// Delete record in database
        /// </summary>
        /// <param name="User_Id"></param>
        public static void DeleteUser(UsersModel User_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("delete from tbl_Users where User_Id = @User_Id", User_Id);

                //or just get the id ex. instead of (UsersModel User_Id) we use just (int User_Id) and execute like below
                //cnn.Execute("delete from tbl_Users where User_Id = @User_Id", new { User_Id = User_Id });
            }
        }

        /// <summary>
        /// Mark User as Blocked in the database
        /// </summary>
        /// <param name="User_Id"></param>
        public static void BlockUnblockUser(UsersModel User_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("update tbl_Users set Blocked = @Blocked where User_Id = @User_Id", User_Id);
            }
        }

    }
}
