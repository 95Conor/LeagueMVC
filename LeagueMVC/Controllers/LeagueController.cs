using System;
using Microsoft.AspNetCore.Mvc;
using LeagueMVC.ViewModels.Classes;
using LeagueMVC.Tasks;
using System.Linq;
using LeagueMVC.Mappers.ViewModel;

namespace LeagueMVC.Controllers
{
    public class LeagueController : Controller
    {
        private APITasks leagueAPITasks;
        private ApplicationTasks leagueApplicationTasks;
        private UserSearchViewModelMapper userSearchViewModelMapper;
        private MatchSearchViewModelMapper matchSearchViewModelMapper;

        // To-do: implement mapping as a Service object which will use polymorphism/interface/generics to avoid multiple mappers
        //private ViewModelMappingService viewModelMappingService;

        public LeagueController()
        {
            leagueAPITasks = new APITasks();
            leagueApplicationTasks = new ApplicationTasks();
            userSearchViewModelMapper = new UserSearchViewModelMapper();
            matchSearchViewModelMapper = new MatchSearchViewModelMapper();
            //viewModelMappingService = new ViewModelMappingService();
        }

        public IActionResult Index()
        {
            return RedirectToAction("UserSearch");
        }

        public IActionResult UserSearch()
        {
            var emptyViewModel = new UserSearchViewModel();
            return View(emptyViewModel);
        }

        [HttpPost]
        public IActionResult UserSearch(UserSearchViewModel userSearchViewModel)
        {
            if (!leagueApplicationTasks.IsValidUsername(userSearchViewModel.UsernameInput))
            {
                ModelState.AddModelError("Username", "Invalid Username");
                var emptyViewModel = new UserSearchViewModel();
                return View(emptyViewModel);
            }

            PopulateUserSearchViewModel(userSearchViewModel);
            return View(userSearchViewModel);
        }

        private void PopulateUserSearchViewModel(UserSearchViewModel userSearchViewModel)
        {
            if (userSearchViewModel != null && !String.IsNullOrEmpty(userSearchViewModel.UsernameInput))
            {
                var userDTO = leagueAPITasks.GetUser(userSearchViewModel.UsernameInput);
                userSearchViewModelMapper.MapFromDTO(userSearchViewModel, userDTO);
                userSearchViewModel.FoundResult = true;
            }
        }

        public IActionResult MatchSearch()
        {
            var emptyViewModel = new MatchSearchViewModel();
            return View(emptyViewModel);
        }

        [HttpPost]
        public IActionResult MatchSearch(MatchSearchViewModel matchSearchViewModel)
        {
            if (!leagueApplicationTasks.IsValidUsername(matchSearchViewModel.UsernameInput))
            {
                ModelState.AddModelError("Username", "Invalid Username");
                var emptyViewModel = new UserSearchViewModel();
                return View(emptyViewModel);
            }

            PopulateMatchSearchViewModel(matchSearchViewModel);
            return View(matchSearchViewModel);
        }

        private void PopulateMatchSearchViewModel(MatchSearchViewModel matchSearchViewModel)
        {
            if (matchSearchViewModel != null && !String.IsNullOrEmpty(matchSearchViewModel.UsernameInput))
            {
                var currentGameInfoDTO = leagueAPITasks.GetCurrentGameInfo(matchSearchViewModel.UsernameInput);
                matchSearchViewModelMapper.MapFromDTO(matchSearchViewModel, currentGameInfoDTO);
                matchSearchViewModel.FoundResult = true;
            }
        }
    }
}
