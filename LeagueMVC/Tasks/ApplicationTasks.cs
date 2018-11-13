using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using LeagueMVC.APIManagement;
using LeagueMVC.Mappers.DTO;

namespace LeagueMVC.Tasks
{
    public class ApplicationTasks
    {
        private APIHelper apiHelper { get; set; }
        private ChampionMasteryDTOMapper championMasteryDTOMapper { get; set; }

        public ApplicationTasks()
        {
            apiHelper = apiHelper ?? new APIHelper();
            championMasteryDTOMapper = championMasteryDTOMapper ?? new ChampionMasteryDTOMapper();
        }

        public bool IsValidUsername(string username)
        {
            if (!String.IsNullOrEmpty(username) && Regex.Match(username, "^[0-9\\p{L} _\\.]+$", RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            return false;
        }

        public Classes.Application.DTO.ChampionMasteryDTO GetChampionMasteryInfo(long summonerId)
        {
            var championMasteryDTO = ChampionMasteryDTOMapper.MapFromAPI(apiHelper.GetChampionMastery(summonerId));
            return championMasteryDTO;
        }
    }
}
