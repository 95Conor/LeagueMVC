using LeagueMVC.Classes.Application.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace LeagueMVC.ViewModels.Classes
{
    public class MatchSearchViewModel
    {
        [DisplayName("Username:")]
        [Required]
        public string UsernameInput { get; set; }

        // To-do: convert the below into UI friendly variables which will be mapped from the DTO in the mapper
        public CurrentGameInfoDTO CurrentGameInfo;

        public List<string> allPlayerUsernames { get; set; }

        public bool FoundResult { get; set; }
    }
}
