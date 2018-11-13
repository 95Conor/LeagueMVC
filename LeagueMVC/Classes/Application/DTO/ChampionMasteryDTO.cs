using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMVC.Classes.Application.DTO
{
    public class ChampionMasteryDTO
    {
        public List<ChampionMasteryDTOChampion> TopTenChampions { get; set; }
        public List<ChampionMasteryDTOChampion> TopTwentyChampions { get; set; }
    }

    public struct ChampionMasteryDTOChampion
    {
        public Champion champion { get; set; }
        public long championPoints { get; set; }
        public DateTime lastPlayTime { get; set; }
    }
}
