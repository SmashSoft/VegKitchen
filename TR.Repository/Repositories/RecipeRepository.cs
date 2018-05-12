using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TR.BusinessObjects.Data.Models;
using TR.Repository.DataContext;
using TR.Repository.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TR.Repository.Repositories
{
    public class RecipeRepository :  GenericRepository<Recipe>, IRecipeRepository
    {
       

        public AppDbContext AppDbContext
        {
            get
            {
                return Context as AppDbContext;
            }
        }

        public RecipeRepository(AppDbContext context):base(context)
        {
          
        }       

        public Recipe GetRecipeById(int recipeId)
        {
            throw new NotImplementedException();
        }

       
        public IEnumerable<Recipe> Recipies => AppDbContext.Recipies.Include("Category");

        public IEnumerable<Recipe> FavoriteRecipes => AppDbContext.Recipies.Where(p => p.IsFavorite).Include("Category");


    }
}


