using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TR.Repository.Interface;
using TR.WebApp.ViewModel;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRecipeRepository _recipeRepo;

        public HomeController(IRecipeRepository reciperepository)
        {
            _recipeRepo = reciperepository;
        }

        public ViewResult Index()
        {

            var homeViewModel = new HomeViewModel
            {
                FavoriteRecipies = _recipeRepo.FavoriteRecipes
            };
            return View(homeViewModel);
        }

       

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
