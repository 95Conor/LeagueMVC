using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueMVC.Classes.Application.DTO;
using LeagueMVC.ViewModels.Classes;

namespace LeagueMVC.Mappers.ViewModel
{
    public class MatchSearchViewModelMapper
    {
        public void MapFromDTO(MatchSearchViewModel matchSearchViewModel, CurrentGameInfoDTO currentGameInfoDTO)
        {
            matchSearchViewModel.CurrentGameInfo = currentGameInfoDTO;
            matchSearchViewModel.allPlayerUsernames = currentGameInfoDTO.allPlayerUsernames;
            // To-do: actual mapping of data object to UI friendly variables in the view model when created properly
        }
    }
}
