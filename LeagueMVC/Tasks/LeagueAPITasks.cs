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
        public Classes.Application.League.User GetUser(string userName)
        {
            var apiHelper = new APIHelper();
            var user = UserMapper.mapFromAPI(apiHelper.GetUser(userName));

            return user;
        }
    }
}
