using System;
using System.Collections.Generic;
using System.Text;
using TR.BusinessObjects.Data.Models;

namespace TR.Repository.Interface
{
    public interface IRecipeRepository: IGenericRepository<Recipe>
    {
        IEnumerable<Recipe> Recipies { get;  }
        IEnumerable<Recipe> FavoriteRecipes{ get;  }

        Recipe GetRecipeById(int recipeId);
       
        
    }
}
