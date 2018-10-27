using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.API;

namespace LeagueMVC.APIManagement
{
    public class APIHelper
    {
        private const string ServicePlatform = "EUW1";
        private const string Host = "euw1.api.riotgames.com";

        private string UsernameRegexValidation = "^[0-9\\p{L} _\\.]+$";

        public User GetUser(string userName)
        {
            // When implemented - make API call to get user.
            return new User() { UserID = "21", Username = userName };
        }

        private void LogAPIError(object error)
        {
            // Implement
        }
    }
}
