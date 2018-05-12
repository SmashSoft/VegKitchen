using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TR.BusinessObjects.Data.Models;
using TR.Repository.Interface;
using TR.WebApp.ViewModel;

namespace TR.WebApp.Controllers
{
    [Authorize]
    public class RecipeController : Controller
    {
        private readonly ICategoryRepository _categoyRepository;
        private readonly IRecipeRepository _recipeRepository;

        public RecipeController(ICategoryRepository categoryRepo, IRecipeRepository recipeRepo)
        {
            _categoyRepository = categoryRepo;
            _recipeRepository = recipeRepo;
        }

        public ViewResult List()
        {

            IEnumerable<Recipe> reipes;
            IEnumerable<Category> categories;

            //categories = _categoyRepository.GetFavoriteCategories();

            reipes = _recipeRepository.Recipies;            
            RecipeListViewModel vm = new RecipeListViewModel();


            vm.Recipes = reipes;
            vm.RecipeCategory = "Break Fast";
            return View(vm);
        }

        
    }
}