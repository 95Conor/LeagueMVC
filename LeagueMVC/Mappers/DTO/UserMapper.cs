using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.API;
using LeagueMVC.Classes.Application.DTO;

namespace LeagueMVC.Mappers.DTO
{
    public class UserMapper
    {
        public static Classes.Application.DTO.UserDTO mapFromAPI(Classes.API.User inputUser)
        {
            Classes.Application.DTO.UserDTO returnUser = new Classes.Application.DTO.UserDTO();
            returnUser.UserID = inputUser.id;
            returnUser.Username = inputUser.name;
            returnUser.LastLogin = DateTimeOffset.FromUnixTimeMilliseconds(inputUser.revisionDate).DateTime;
            returnUser.TimeSinceLastLogin = DateTime.Now - returnUser.LastLogin;
            return returnUser;
        }
    }
}
