using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using LeagueMVC.ViewModels.League;
using LeagueMVC.Classes.Application;
using LeagueMVC.Interfaces;
using LeagueMVC.Tasks;

namespace LeagueMVC.Controllers
{
    public class LeagueController : Controller
    {
        private ILeagueAPITasks leagueAPITasks;

        public LeagueController()
        {
            this.leagueAPITasks = new LeagueAPITasks();
        }

        public IActionResult Index()
        {
            var manualViewModel = InstantiateIndexViewModel("95Conor");
            return View(manualViewModel);
        }

        // Need to make another function for when they return back to the controller

        private IndexViewModel InstantiateIndexViewModel(string userName = "")
        {
            if (!String.IsNullOrEmpty(userName))
            {
                var user = leagueAPITasks.GetUser(userName);
                return new IndexViewModel()
                {
                    Introduction = "Please search for a user.",
                    User = user
                };
            }

            return new IndexViewModel()
            {
                Introduction = "Please search for a user."
            };
        }
    }
}
