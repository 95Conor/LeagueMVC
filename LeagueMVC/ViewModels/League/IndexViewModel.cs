using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeagueMVC.Classes.Application.League;

namespace LeagueMVC.ViewModels.League
{
    public class IndexViewModel
    {
        public string Introduction { get; set; } 

        public User User { get; set; }
    }
}
