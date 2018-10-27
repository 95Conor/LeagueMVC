using System;
using Microsoft.AspNetCore.Mvc;
using LeagueMVC.ViewModels.League;
using LeagueMVC.Interfaces;
using LeagueMVC.Tasks;
using System.Linq;

namespace LeagueMVC.Controllers
{
    public class LeagueController : Controller
    {
        private ILeagueAPITasks leagueAPITasks;
        private ILeagueApplicationTasks leagueApplicationTasks;

        public LeagueController()
        {
            leagueAPITasks = new LeagueAPITasks();
            leagueApplicationTasks = new LeagueApplicationTasks();
        }

        public IActionResult Index()
        {
            return RedirectToAction("UserSearch");
        }

        public IActionResult UserSearch()
        {
            var emptyViewModel = InstantiateUserSearchViewModel();
            return View(emptyViewModel);
        }

        [HttpPost]
        public IActionResult UserSearch(UserSearchViewModel userSearchViewModel)
        {
            if (!leagueApplicationTasks.IsValidUsername(userSearchViewModel.Username))
            {
                ModelState.AddModelError("Username", "Invalid username");
                var emptyViewModel = InstantiateUserSearchViewModel();
                return View(emptyViewModel);
            }

            var returnViewModel = InstantiateUserSearchViewModel(userSearchViewModel.Username);
            return View(returnViewModel);
        }

        private UserSearchViewModel InstantiateUserSearchViewModel(string userName = "")
        {
            if (!String.IsNullOrEmpty(userName))
            {
                var user = leagueAPITasks.GetUser(userName);
                return new UserSearchViewModel()
                {
                    User = user
                };
            }

            return new UserSearchViewModel();
        }
    }
}
