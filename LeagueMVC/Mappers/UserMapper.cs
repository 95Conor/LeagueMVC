using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.API;
using LeagueMVC.Classes.Application.League;

namespace LeagueMVC.Mappers
{
    public class UserMapper
    {
        public static Classes.Application.League.User mapFromAPI(Classes.API.User inputUser)
        {
            Classes.Application.League.User returnUser = new Classes.Application.League.User();
            returnUser.UserID = inputUser.UserID;
            returnUser.Username = inputUser.Username;
            return returnUser;
        }
    }
}
