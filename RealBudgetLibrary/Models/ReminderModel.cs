using System;
using System.Collections.Generic;
using System.Linq;

namespace RealBudgetLibrary
{
    public class ReminderModel
    {
        public int Reminder_Id { get; set; }
        public int User_Id { get; set; }
        public string Title { get; set; }
        public DateTime RStart { get; set; }
        public DateTime REnd { get; set; }
        public string Status { get; set; }
        public string Seen { get; set; }
        public string Notes { get; set; }

        public string FullReminder
        {
            get
            {
                return $"{ Title } { RStart } { REnd } { Notes }";
            }
        }

        public int CountReminders()
        {
            List<ReminderModel> rem = ReminderDataProcessor.GetAllReminders().Where(x => x.Seen == "no").ToList();

            int total = rem.Count();

            return total;
        }
    }
}
