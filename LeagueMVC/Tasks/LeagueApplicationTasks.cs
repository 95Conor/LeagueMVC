using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Interfaces;
using System.Text.RegularExpressions;

namespace LeagueMVC.Tasks
{
    public class LeagueApplicationTasks : ILeagueApplicationTasks
    {
        public bool IsValidUsername(string username)
        {
            if (!String.IsNullOrEmpty(username) && Regex.Match(username, "^[0-9\\p{L} _\\.]+$", RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            return false;
        }
    }
}
