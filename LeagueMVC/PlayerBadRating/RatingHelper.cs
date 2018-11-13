using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.Application;

namespace LeagueMVC.PlayerBadRating
{
    public class RatingHelper
    {
        private List<ChampionRating> allChampionRatings { get; set; }

        public List<ChampionRating> GetAllChampionRatings()
        {
            return allChampionRatings;
        }

        public ChampionRating GetChampionRatingByChampion(Champion champion)
        {
            return allChampionRatings.Any(x => x.Champion.Equals(champion))
                ? allChampionRatings.FirstOrDefault(x => x.Champion.Equals(champion))
                : new ChampionRating() { Champion = new Champion() { Name = "Error", Id = 0 }, Rating = 0 };
        }

        public ChampionRating GetChampionRatingByChampionName(string name)
        {
            if (name.Trim().IndexOf(' ') != -1)
            {
                name = name.Replace(" ", string.Empty);
            }

            return allChampionRatings.Any(x => x.Champion.Name.ToLower() == name.ToLower())
                ? allChampionRatings.FirstOrDefault(x => x.Champion.Name.ToLower() == name.ToLower())
                : new ChampionRating() { Champion = new Champion() { Name = "Error", Id = 0 }, Rating = 0 };
        }

        public List<ChampionRating> GetAllChampionRatingsByRatingRange(int lowerBound, int upperBound)
        {
            return allChampionRatings.Where(x => x.Rating >= lowerBound && x.Rating <= upperBound).ToList();
        }

        public RatingHelper()
        {
            ChampionHelper championHelper = new ChampionHelper();

            allChampionRatings = new List<ChampionRating>()
            {
                new ChampionRating() { Champion = championHelper.GetChampionByName("Aatrox"), Rating = 50 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Ahri"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Akali"), Rating = 65 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Alistar"), Rating = 15 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Amumu"), Rating = 50 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Anivia"), Rating = 60 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Annie"), Rating = 75 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Ashe"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("AurelionSol"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Azir"), Rating = 5 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Bard"), Rating = 5 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Blitzcrank"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Brand"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Braum"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Caitlyn"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Camille"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Cassiopeia"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Chogath"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Corki"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Darius"), Rating = 70 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Diana"), Rating = 65 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Draven"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("DrMundo"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Ekko"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Elise"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Evelyn"), Rating = 35 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Ezreal"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Fiddlesticks"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Fiora"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Fizz"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Galio"), Rating = 70 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Gangplank"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Garen"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Gnar"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Gragas"), Rating = 65 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Graves"), Rating = 65 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Hecarim"), Rating = 75 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Heimerdinger"), Rating = 90 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Illaoi"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Irelia"), Rating = 50 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Ivern"), Rating = 60 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Janna"), Rating = 70 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Jarvan"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Jax"), Rating = 85 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Jayce"), Rating = 50 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Jhin"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Jinx"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Kaisa"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Kalista"), Rating = 5 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Karma"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Karthus"), Rating = 70 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Kassadin"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Katarina"), Rating = 50 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Kayle"), Rating = 60 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Kayn"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Kennen"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Khazix"), Rating = 25 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Kindred"), Rating = 25 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Kled"), Rating = 50 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("KogMaw"), Rating = 55 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Leblanc"), Rating = 50 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("LeeSin"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Leona"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Lissandra"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Lucian"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Lulu"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Lux"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Malphite"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Malzahar"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Maokai"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("MasterYi"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("MissFortune"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("MonkeyKing"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Wukong"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Mordekaiser"), Rating = 90 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Morgana"), Rating = 75 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Nami"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Nasus"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Nautilus"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Nidalee"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Nocturne"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Nunu"), Rating = 75 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Olaf"), Rating = 85 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Orianna"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Ornn"), Rating = 85 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Pantheon"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Poppy"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Pyke"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Quinn"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Rakan"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Rammus"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("RekSai"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Renekton"), Rating = 55 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Rengar"), Rating = 75 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Riven"), Rating = 45 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Rumble"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Ryze"), Rating = 30 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Sejuani"), Rating = 90 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Shaco"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Shen"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Shyvana"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Singed"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Sion"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Sivir"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Skarner"), Rating = 90 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Sona"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Soraka"), Rating = 90 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Swain"), Rating = 90 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Syndra"), Rating = 60 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("TahmKench"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Taliyah"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Talon"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Taric"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Teemo"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Thresh"), Rating = 5 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Tristana"), Rating = 70 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Trundle"), Rating = 70 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Tryndamere"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("TwistedFate"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Twitch"), Rating = 60 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Udyr"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Urgot"), Rating = 80 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Varus"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Vayne"), Rating = 10 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Veigar"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Velkoz"), Rating = 75 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Vi"), Rating = 60 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Viktor"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Vladimir"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Volibear"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Warwick"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Xayah"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Xerath"), Rating = 60 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("XinZhao"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Yasuo"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Yorick"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Zac"), Rating = 60 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Zed"), Rating = 40 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Ziggs"), Rating = 20 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Zilean"), Rating = 65 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Zoe"), Rating = 100 },
                new ChampionRating() { Champion = championHelper.GetChampionByName("Zyra"), Rating = 60 },
            };
        }
    }
}
