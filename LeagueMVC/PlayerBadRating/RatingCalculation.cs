using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.API;
using LeagueMVC.APIManagement;
using LeagueMVC.Classes.Application.DTO;
using LeagueMVC.Mappers.DTO;
using LeagueMVC.Tasks;

namespace LeagueMVC.PlayerBadRating
{
    public class RatingCalculation
    {
        // To-do - make a rating for 10 and 20, or rather, make the rating a function which you pass a value to to check the top X amount of champs
        public int rating { get; set; }
        private ApplicationTasks applicationTasks { get; set; }

        public ChampionMasteryDTO championMasteryDTO { get; set; }

        public RatingCalculation (long summonerId)
        {
            applicationTasks = new ApplicationTasks();
            this.championMasteryDTO = applicationTasks.GetChampionMasteryInfo(summonerId);
            CalculateRating();
        }

        // To-do: change calculation to base the numbers also on the total number of games/champ points they have on the specific champ
        // i.e a fiddlesticks MAIN should weight the fiddlesticks proportion greater
        // Maybe sum up the total amount of champion points of all 20 and then weight them based on each individual one
        // pseudo:
        // var totalPoints = SUM(all champion points)
        // var fiddleSticksBadRating = ( ratingHelper.GetRating(fiddlesticks) * fiddlesticks.totalPoints ) / (totalPoints / 20) 
        // Or something like that...

        private void CalculateRating()
        {
            int sum = 0;
            RatingHelper ratingHelper = new RatingHelper();

            foreach (ChampionMasteryDTOChampion champMasteryDTOChampion in championMasteryDTO.TopTwentyChampions)
            {
                sum += ratingHelper.GetChampionRatingByChampion(champMasteryDTOChampion.champion).Rating;
            }

            decimal rating = sum / 20;
            this.rating = Convert.ToInt32(rating);
        }
    }
}
