using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TR.BusinessObjects.Data.Models;
using TR.Repository.Interface;
using TR.Repository.DataContext;
using System.Linq;

namespace TR.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
             

        public AppDbContext AppDbContext {
            get
            {
                return Context as AppDbContext;
            }
        }

        public CategoryRepository(AppDbContext context):base(context)
        {
            
        }

        public IEnumerable<Category> GetFavoriteCategories()
        {
            return AppDbContext.Categories.ToList();
        }

        public IEnumerable<Category> Categories => AppDbContext.Categories;
    }
}
