using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TR.BusinessObjects.Data.Models;

namespace TR.Repository.DataContext
{
    public class DbInitializer
    {       

        public static void Seed(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();
            if (!context.Categories.Any())
            {
            context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if(!context.Recipies.Any())
            {
                context.Add(
                     new Recipe
                     {
                         Name = "Wine",
                         ShortDescription = "Making of Wine",
                         LongDescription = "will be added later",
                         ImageUrl = "http://www.foodpaa.com/wp-content/uploads/2017/12/MASALA-DOSA-1.jpg",
                         ImageThumbnailUrl = "",
                         IsFavorite = true,
                         Category = categories["Alcoholic"]
                     });
                
            }

            context.SaveChanges();
        }



        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { Name = "Alcoholic", Description="All alcoholic drinks" },
                        new Category { Name = "Non-alcoholic", Description="All non-alcoholic drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.Name, genre);
                    }
                }

                return categories;
            }
        }
    }
}
