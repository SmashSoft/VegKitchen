using System;
using System.Collections.Generic;
using System.Text;
using TR.BusinessObjects.Data.Models;
using TR.Repository.Interface;
using System.Linq;

namespace TR.Repository.MockRepo
{
  /*  public class MockRecipeRepository : IRecipeRepository
    {

        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Recipe> Recipies {
            get
            {
                return new List<Recipe>
                {
                    new Recipe{
                        Name="Dosa",
                        ShortDescription="Making of Dosa",
                        LongDescription="will be added later",
                        ImageUrl="http://www.foodpaa.com/wp-content/uploads/2017/12/MASALA-DOSA-1.jpg",
                        ImageThumbnailUrl="",
                        IsFavorite=true,
                        Category= _categoryRepository.Categories.First()
                    },


                    new Recipe{
                        Name="Iddly",
                        ShortDescription="Making of Idly",
                        LongDescription="will be added later",
                        ImageUrl="http://www.foodpaa.com/wp-content/uploads/2017/12/IDLY1.jpg",
                        ImageThumbnailUrl="",
                        IsFavorite=true,
                        Category= _categoryRepository.Categories.First()
                    },
                     new Recipe{
                        Name="Iddly",
                        ShortDescription="Making of Idly",
                        LongDescription="will be added later",
                        ImageUrl="http://www.foodpaa.com/wp-content/uploads/2017/12/ONION-MASALA-UTTAPUM1.jpg",
                        ImageThumbnailUrl="",
                        IsFavorite=true,
                        Category= _categoryRepository.Categories.First()
                    },
                      new Recipe{
                        Name="Iddly",
                        ShortDescription="Making of Idly",
                        LongDescription="will be added later",
                        ImageUrl="http://www.foodpaa.com/wp-content/uploads/2017/12/SAMBER-VADA1.jpg",
                        ImageThumbnailUrl="",
                        IsFavorite=true,
                        Category= _categoryRepository.Categories.First()
                    }

                };
            }            
        }


        public IEnumerable<Recipe> FavoriteRecipes { get; set; }

        public Recipe GetRecipeById(int recipeId)
        {
            throw new NotImplementedException();
        }
    }*/
}
