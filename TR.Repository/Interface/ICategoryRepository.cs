using System;
using System.Collections.Generic;
using System.Text;
using TR.BusinessObjects.Data.Models;

namespace TR.Repository.Interface
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        IEnumerable<Category>  Categories { get;  }

        IEnumerable<Category> GetFavoriteCategories();

    }
}
