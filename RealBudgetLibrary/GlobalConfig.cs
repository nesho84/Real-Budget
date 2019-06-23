using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace RealBudgetLibrary
{
    public class GlobalConfig
    {
        /// <summary>
        /// Getting the Connectionstring from App.config
        /// </summary>
        /// <returns></returns>
        public static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SqliteConn"].ConnectionString;
        }

        /// <summary>
        /// Checking the database Connection
        /// </summary>
        /// <returns></returns>
        public static bool CheckDBConnection()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Getting the UID(User_Id) stored in App.config, this will be updated every time a user loggedin
        /// </summary>
        /// <returns></returns>
        public static int GetUID()
        {
            return int.Parse(ConfigurationManager.AppSettings["UID"]);
        }

        /// <summary>
        /// Getting the UserCurrency stored in App.config, this will be updated every time a user loggedin
        /// </summary>
        /// <returns></returns>
        public static string GetUserCurrency()
        {
            return ConfigurationManager.AppSettings["UserCurrency"];
        }

        /// <summary>
        /// Convert a decimal number to Money string format "00,00.00"
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string SetFormat(decimal number)
        {
            string formatedDecimal;

            if (number == 0)
            {
                formatedDecimal = number.ToString("0");
            }
            else
            {
                formatedDecimal = number.ToString("N2");
            }

            return formatedDecimal;

            /*
            return string.Format("{0:N}", Balance);
            //or
            Balance.ToString("#,##0.00");
            */
        }
    }
}
