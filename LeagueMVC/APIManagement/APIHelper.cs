using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.API;

namespace LeagueMVC.APIManagement
{
    public class APIHelper
    {
        public User GetUser(string userName)
        {
            // When implemented - make API call to get user.
            return new User() { UserID = "21", Username = userName };
        }
    }
}
