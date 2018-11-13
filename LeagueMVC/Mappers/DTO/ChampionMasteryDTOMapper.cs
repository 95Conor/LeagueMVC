using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.Application.DTO;
using LeagueMVC.Classes.Application;

namespace LeagueMVC.Mappers.DTO
{
    public class ChampionMasteryDTOMapper
    {
        public static Classes.Application.DTO.ChampionMasteryDTO MapFromAPI(List<Classes.API.ChampionMastery> inputChampionMastery)
        {
            Classes.Application.DTO.ChampionMasteryDTO returnChampionMastery = new Classes.Application.DTO.ChampionMasteryDTO();

            List<ChampionMasteryDTOChampion> allChampions = ChampionMasteryDTOChampionList(inputChampionMastery).ToList();
            List<ChampionMasteryDTOChampion> allChampionsOrdered = allChampions.OrderByDescending(x => x.championPoints).ToList();

            returnChampionMastery.TopTenChampions = allChampionsOrdered.Take(10).ToList();
            returnChampionMastery.TopTwentyChampions = allChampionsOrdered.Take(20).ToList();

            return returnChampionMastery;
        }

        private static IEnumerable<ChampionMasteryDTOChampion> ChampionMasteryDTOChampionList(List<Classes.API.ChampionMastery> inputChampionMastery)
        {
            foreach (var championMastery in inputChampionMastery)
            {
                yield return new ChampionMasteryDTOChampion()
                {
                    champion = new ChampionHelper().GetChampionById(championMastery.championId),
                    championPoints = championMastery.championPoints,
                    lastPlayTime = DateTimeOffset.FromUnixTimeMilliseconds(championMastery.lastPlayTime).DateTime
                };
            }
        }
    }
}
