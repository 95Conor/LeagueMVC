using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.ViewModels.Classes;

namespace LeagueMVC.Mappers.ViewModel
{
    public class UserSearchViewModelMapper
    {
        public void MapFromDTO(UserSearchViewModel userSearchViewModel, Classes.Application.DTO.UserDTO userDTO)
        {
            userSearchViewModel.Username = userDTO.Username;
            userSearchViewModel.UserID = userDTO.UserID;
            userSearchViewModel.LastLogin = userDTO.LastLogin;
            userSearchViewModel.TimeSinceLastLogin = userDTO.TimeSinceLastLogin;
        }
    }
}
