using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.API;
using LeagueMVC.APIManagement;

namespace LeagueMVC.PlayerBadRating
{
    public class RatingCalculation
    {
        public int rating { get; set; }
        private APIHelper apiHelper { get; set; }

        //To-do: This should be a different object which has been mapped from ChampionMastery 
        // Containing just the nice stuff we care about for calculations
        private ChampionMastery championMastery { get; set; }

        public RatingCalculation (long summonerId)
        {
            apiHelper = new APIHelper();
            
            //To-do: This will map from the API object to the above
            championMastery = apiHelper.GetChampionMastery(summonerId);
            CalculateRating();
        }

        private void CalculateRating()
        {
            // To-do: actual calculation based on both champ points and our pre-defined ratings
            rating = 100;
        }
    }
}
