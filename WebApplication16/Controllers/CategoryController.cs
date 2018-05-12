using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TR.BusinessObjects.Data.Models;
using TR.Repository.Interface;
using TR.WebApp.ViewModel;

namespace TR.WebApp.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepo)
        {
            _categoryRepository = categoryRepo;

        }

        public ViewResult List()
        {
            var vm = new CategoryListViewModel();
            // Hard coded for demo. You can replace with real data from db
            IEnumerable<Category> c = _categoryRepository.Categories;
            vm.Categories = c.Select(x => new SelectListItem { Value = x.CategoryId.ToString(), Text = x.Name }).ToList();
          
            
            return View(vm);
        }

        public ViewResult Details()
        {
            IEnumerable<Category> tabledata = _categoryRepository.GetFavoriteCategories();
            return View(tabledata);
        }
        
    }
}