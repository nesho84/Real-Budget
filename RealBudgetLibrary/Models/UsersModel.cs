using System;
using System.Collections.Generic;
using System.Linq;

namespace RealBudgetLibrary
{
    public class UsersModel
    {
        public int User_Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string User_Currency { get; set; }
        public string Access_Role { get; set; }
        public string Blocked { get; set; }
        public int ImageIndex { get; set; }

        public bool IsAdmin()
        {
            UsersModel user = UsersDataProcessor.GetByUser_Id(GlobalConfig.GetUID());

            if (user.Access_Role == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
