using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.Application;
using LeagueMVC.APIManagement;
using LeagueMVC.Mappers.DTO;

namespace LeagueMVC.Tasks
{
    public class APITasks
    {
        // Don't want to reinitialise the HttpClient multiple times so keep APIHelper as static use
        private static APIHelper apiHelper { get; set; }

        public APITasks()
        {
            apiHelper = apiHelper ?? new APIHelper();
        }

        public Classes.Application.DTO.UserDTO GetUser(string userName)
        {
            var user = UserMapper.mapFromAPI(apiHelper.GetUser(userName));
            return user;
        }

        public Classes.Application.DTO.CurrentGameInfoDTO GetCurrentGameInfo(string userName)
        {
            var user = apiHelper.GetUser(userName);
            var currentGameInfo = CurrentGameInfoMapper.MapFromAPI(apiHelper.GetCurrentGameInfo(user.id));
            return currentGameInfo;
        }
    }
}
