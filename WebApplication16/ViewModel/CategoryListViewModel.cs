using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TR.BusinessObjects.Data.Models;

namespace TR.WebApp.ViewModel
{
    public class CategoryListViewModel
    {
        public IEnumerable<SelectListItem> Categories { get; set; }
        public int SelectedCategoryId { get; set; }
    }
}
