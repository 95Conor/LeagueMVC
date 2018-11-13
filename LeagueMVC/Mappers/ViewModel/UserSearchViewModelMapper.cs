using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.ViewModels.Classes;
using LeagueMVC.PlayerBadRating;

namespace LeagueMVC.Mappers.ViewModel
{
    public class UserSearchViewModelMapper
    {
        public void MapFromDTO(UserSearchViewModel userSearchViewModel, Classes.Application.DTO.UserDTO userDTO)
        {
            userSearchViewModel.Username = userDTO.Username;
            userSearchViewModel.UserID = userDTO.SummonerID;
            userSearchViewModel.LastLogin = userDTO.LastLogin;
            userSearchViewModel.TimeSinceLastLogin = userDTO.TimeSinceLastLogin;
        }

        public void MapFromDTO(UserSearchViewModel userSearchViewModel, RatingCalculation ratingCalculation)
        {
            userSearchViewModel.PlayerBadRating = ratingCalculation.rating;
            userSearchViewModel.TopTenChampions = ratingCalculation.championMasteryDTO.TopTenChampions;
            userSearchViewModel.TopTwentyChampions = ratingCalculation.championMasteryDTO.TopTwentyChampions;
        }
    }
}
