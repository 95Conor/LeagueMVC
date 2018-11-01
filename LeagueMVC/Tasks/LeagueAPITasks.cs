using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.Application;
using LeagueMVC.APIManagement;
using LeagueMVC.Mappers;
using LeagueMVC.Interfaces;

namespace LeagueMVC.Tasks
{
    public class LeagueAPITasks : ILeagueAPITasks
    {
        // Don't want to reinitialise the HttpClient multiple times so keep APIHelper as static use
        private static APIHelper apiHelper { get; set; }

        public LeagueAPITasks()
        {
            apiHelper = apiHelper ?? new APIHelper();
        }

        public Classes.Application.League.User GetUser(string userName)
        {
            var user = UserMapper.mapFromAPI(apiHelper.GetUser(userName));
            return user;
        }
    }
}
