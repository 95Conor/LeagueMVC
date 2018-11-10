using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeagueMVC.Classes.Application.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LeagueMVC.ViewModels.Classes
{
    public class UserSearchViewModel
    {
        public string Username { get; set; }
        public long UserID { get; set; }
        public DateTime LastLogin { get; set; }
        public TimeSpan TimeSinceLastLogin { get; set; }
        public bool FoundResult { get; set; }

        [DisplayName("Username:")]
        [Required]
        public string UsernameInput { get; set; }
    }
}
