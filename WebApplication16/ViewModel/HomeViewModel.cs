using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TR.BusinessObjects.Data.Models;

namespace TR.WebApp.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Recipe> FavoriteRecipies { get; set; }
    }
}
