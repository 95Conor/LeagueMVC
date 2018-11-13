using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMVC.Mappers.DTO
{
    public class CurrentGameInfoMapper
    {
        public static Classes.Application.DTO.CurrentGameInfoDTO MapFromAPI(Classes.API.CurrentGameInfo inputCurrentGameInfo)
        {
            Classes.Application.DTO.CurrentGameInfoDTO returnCurrentGameInfo = new Classes.Application.DTO.CurrentGameInfoDTO();

            returnCurrentGameInfo.allPlayerUsernames = (inputCurrentGameInfo.participants != null && inputCurrentGameInfo.participants.Any())
                ? inputCurrentGameInfo.participants.Select(x => x.summonerName).ToList() 
                : new List<string>() { "No participants found" };

            // To-do: mapping
            return returnCurrentGameInfo;
        }
    }
}
