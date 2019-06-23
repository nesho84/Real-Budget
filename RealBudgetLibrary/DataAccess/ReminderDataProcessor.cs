using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace RealBudgetLibrary
{
    public static class ReminderDataProcessor
    {
        //Identifies the User_Id stored in App.config, this will be updated every time a user logedin
        private static readonly int User_Id = GlobalConfig.GetUID();

        /// <summary>
        /// Getting All records from database
        /// </summary>
        public static List<ReminderModel> GetAllReminders()
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                return cnn.Query<ReminderModel>("Select * From tbl_Reminder WHERE User_Id = @User_Id", new { User_Id }).ToList();
            }
        }

        /// <summary>
        /// Insert into database
        /// </summary>
        /// <param name="reminderModel"></param>
        public static void InsertReminder(ReminderModel reminderModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("insert into tbl_Reminder (User_Id, Title, RStart, REnd, Status, Seen, Notes) values " +
                    "(@User_Id, @Title, @RStart, @REnd, @Status, @Seen, @Notes)", reminderModel);
            }
        }

        /// <summary>
        /// Update record in database
        /// </summary>
        /// <param name="Reminder_Id"></param>
        public static void UpdateReminder(ReminderModel Reminder_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("update tbl_Reminder set Title=@Title, RStart=@RStart, REnd=@REnd, Status=@Status, Seen=@Seen, Notes=@Notes where Reminder_Id=@Reminder_Id", Reminder_Id);
            }
        }

        /// <summary>
        /// Delete record in database
        /// </summary>
        /// <param name="Reminder_Id"></param>
        public static void DeleteReminder(ReminderModel Reminder_Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.LoadConnectionString()))
            {
                cnn.Execute("delete from tbl_Reminder where Reminder_Id = @Reminder_Id", Reminder_Id);
            }
        }
    }
}
