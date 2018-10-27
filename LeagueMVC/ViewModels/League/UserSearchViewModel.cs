using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeagueMVC.Classes.Application.League;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LeagueMVC.ViewModels.League
{
    public class UserSearchViewModel
    {
        public User User { get; set; }

        [DisplayName("Username:")]
        [Required]
        public string Username { get; set; }
    }
}
