using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMVC.Classes.Application
{
    public class ChampionHelper
    {
        private List<Champion> allChampions { get; set; }

        public List<Champion> GetAllChampions()
        {
            return allChampions;
        }

        public Champion GetChampionById(long id)
        {
            return allChampions.Any(x => x.Id == id) 
                ? allChampions.FirstOrDefault(x => x.Id == id) 
                : new Champion() { Name = "Error", Id = 0 };
        }

        public Champion GetChampionByName(string name)
        {
            if (name.Trim().IndexOf(' ') != -1)
            {
                name = name.Replace(" ", string.Empty);
            }

            return allChampions.Any(x => x.Name.ToLower() == name.ToLower()) 
                ? allChampions.FirstOrDefault(x => x.Name.ToLower() == name.ToLower()) 
                : new Champion() { Name = "Error", Id = 0 };
        }

        public ChampionHelper()
        {
            allChampions = new List<Champion>()
            {
                new Champion() { Name = "Aatrox", Id = 266 },
                new Champion() { Name = "Ahri", Id = 103 },
                new Champion() { Name = "Akali", Id = 84 },
                new Champion() { Name = "Alistar", Id = 12 },
                new Champion() { Name = "Amumu", Id = 32 },
                new Champion() { Name = "Anivia", Id = 34 },
                new Champion() { Name = "Annie", Id = 1 },
                new Champion() { Name = "Ashe", Id = 22 },
                new Champion() { Name = "AurelionSol", Id = 136 },
                new Champion() { Name = "Azir", Id = 268 },
                new Champion() { Name = "Bard", Id = 432 },
                new Champion() { Name = "Blitzcrank", Id = 53 },
                new Champion() { Name = "Brand", Id = 63 },
                new Champion() { Name = "Braum", Id = 201 },
                new Champion() { Name = "Caitlyn", Id = 51 },
                new Champion() { Name = "Camille", Id = 164 },
                new Champion() { Name = "Cassiopeia", Id = 69 },
                new Champion() { Name = "Chogath", Id = 31 },
                new Champion() { Name = "Corki", Id = 42 },
                new Champion() { Name = "Darius", Id = 122 },
                new Champion() { Name = "Diana", Id = 131 },
                new Champion() { Name = "Draven", Id = 119 },
                new Champion() { Name = "DrMundo", Id = 36 },
                new Champion() { Name = "Ekko", Id = 245 },
                new Champion() { Name = "Elise", Id = 60 },
                new Champion() { Name = "Evelynn", Id = 28 },
                new Champion() { Name = "Ezreal", Id = 81 },
                new Champion() { Name = "Fiddlesticks", Id = 9 },
                new Champion() { Name = "Fiora", Id = 114 },
                new Champion() { Name = "Fizz", Id = 105 },
                new Champion() { Name = "Galio", Id = 3 },
                new Champion() { Name = "Gangplank", Id = 41 },
                new Champion() { Name = "Garen", Id = 86 },
                new Champion() { Name = "Gnar", Id = 150 },
                new Champion() { Name = "Gragas", Id = 79 },
                new Champion() { Name = "Graves", Id = 104 },
                new Champion() { Name = "Hecarim", Id = 120 },
                new Champion() { Name = "Heimerdinger", Id = 74 },
                new Champion() { Name = "Illaoi", Id = 420 },
                new Champion() { Name = "Irelia", Id = 39 },
                new Champion() { Name = "Ivern", Id = 427 },
                new Champion() { Name = "Janna", Id = 40 },
                new Champion() { Name = "JarvanIV", Id = 59 },
                new Champion() { Name = "Jax", Id = 24 },
                new Champion() { Name = "Jayce", Id = 126 },
                new Champion() { Name = "Jhin", Id = 202 },
                new Champion() { Name = "Jinx", Id = 222 },
                new Champion() { Name = "Kaisa", Id = 145 },
                new Champion() { Name = "Kalista", Id = 429 },
                new Champion() { Name = "Karma", Id = 43 },
                new Champion() { Name = "Karthus", Id = 30 },
                new Champion() { Name = "Kassadin", Id = 38 },
                new Champion() { Name = "Katarina", Id = 55 },
                new Champion() { Name = "Kayle", Id = 10 },
                new Champion() { Name = "Kayn", Id = 141 },
                new Champion() { Name = "Kennen", Id = 85 },
                new Champion() { Name = "Khazix", Id = 121 },
                new Champion() { Name = "Kindred", Id = 203 },
                new Champion() { Name = "Kled", Id = 240 },
                new Champion() { Name = "KogMaw", Id = 96 },
                new Champion() { Name = "Leblanc", Id = 7 },
                new Champion() { Name = "LeeSin", Id = 64 },
                new Champion() { Name = "Leona", Id = 89 },
                new Champion() { Name = "Lissandra", Id = 127 },
                new Champion() { Name = "Lucian", Id = 236 },
                new Champion() { Name = "Lulu", Id = 117 },
                new Champion() { Name = "Lux", Id = 99 },
                new Champion() { Name = "Malphite", Id = 54 },
                new Champion() { Name = "Malzahar", Id = 90 },
                new Champion() { Name = "Maokai", Id = 57 },
                new Champion() { Name = "MasterYi", Id = 11 },
                new Champion() { Name = "MissFortune", Id = 21 },
                new Champion() { Name = "MonkeyKing", Id = 62 },
                new Champion() { Name = "Wukong", Id = 62 },
                new Champion() { Name = "Mordekaiser", Id = 82 },
                new Champion() { Name = "Morgana", Id = 25 },
                new Champion() { Name = "Nami", Id = 267 },
                new Champion() { Name = "Nasus", Id = 75 },
                new Champion() { Name = "Nautilus", Id = 111 },
                new Champion() { Name = "Nidalee", Id = 76 },
                new Champion() { Name = "Nocturne", Id = 56 },
                new Champion() { Name = "Nunu", Id = 20 },
                new Champion() { Name = "Olaf", Id = 2 },
                new Champion() { Name = "Orianna", Id = 61 },
                new Champion() { Name = "Ornn", Id = 516 },
                new Champion() { Name = "Pantheon", Id = 80 },
                new Champion() { Name = "Poppy", Id = 78 },
                new Champion() { Name = "Pyke", Id = 555 },
                new Champion() { Name = "Quinn", Id = 133 },
                new Champion() { Name = "Rakan", Id = 497 },
                new Champion() { Name = "Rammus", Id = 33 },
                new Champion() { Name = "RekSai", Id = 421 },
                new Champion() { Name = "Renekton", Id = 58 },
                new Champion() { Name = "Rengar", Id = 107 },
                new Champion() { Name = "Riven", Id = 92 },
                new Champion() { Name = "Rumble", Id = 68 },
                new Champion() { Name = "Ryze", Id = 13 },
                new Champion() { Name = "Sejuani", Id = 113 },
                new Champion() { Name = "Shaco", Id = 35 },
                new Champion() { Name = "Shen", Id = 98 },
                new Champion() { Name = "Shyvana", Id = 102 },
                new Champion() { Name = "Singed", Id = 27 },
                new Champion() { Name = "Sion", Id = 14 },
                new Champion() { Name = "Sivir", Id = 15 },
                new Champion() { Name = "Skarner", Id = 72 },
                new Champion() { Name = "Sona", Id = 37 },
                new Champion() { Name = "Soraka", Id = 16 },
                new Champion() { Name = "Swain", Id = 50 },
                new Champion() { Name = "Syndra", Id = 134 },
                new Champion() { Name = "TahmKench", Id = 223 },
                new Champion() { Name = "Taliyah", Id = 163 },
                new Champion() { Name = "Talon", Id = 91 },
                new Champion() { Name = "Taric", Id = 44 },
                new Champion() { Name = "Teemo", Id = 17 },
                new Champion() { Name = "Thresh", Id = 412 },
                new Champion() { Name = "Tristana", Id = 18 },
                new Champion() { Name = "Trundle", Id = 48 },
                new Champion() { Name = "Tryndamere", Id = 23 },
                new Champion() { Name = "TwistedFate", Id = 4 },
                new Champion() { Name = "Twitch", Id = 29 },
                new Champion() { Name = "Udyr", Id = 77 },
                new Champion() { Name = "Urgot", Id = 6 },
                new Champion() { Name = "Varus", Id = 110 },
                new Champion() { Name = "Vayne", Id = 67 },
                new Champion() { Name = "Veigar", Id = 45 },
                new Champion() { Name = "Velkoz", Id = 161 },
                new Champion() { Name = "Vi", Id = 254 },
                new Champion() { Name = "Viktor", Id = 112 },
                new Champion() { Name = "Vladimir", Id = 8 },
                new Champion() { Name = "Volibear", Id = 106 },
                new Champion() { Name = "Warwick", Id = 19 },
                new Champion() { Name = "Xayah", Id = 498 },
                new Champion() { Name = "Xerath", Id = 101 },
                new Champion() { Name = "XinZhao", Id = 5 },
                new Champion() { Name = "Yasuo", Id = 157 },
                new Champion() { Name = "Yorick", Id = 83 },
                new Champion() { Name = "Zac", Id = 154 },
                new Champion() { Name = "Zed", Id = 238 },
                new Champion() { Name = "Ziggs", Id = 115 },
                new Champion() { Name = "Zilean", Id = 26 },
                new Champion() { Name = "Zoe", Id = 142 },
                new Champion() { Name = "Zyra", Id = 143 }
            };
        }
    }
}
