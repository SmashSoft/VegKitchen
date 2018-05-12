using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TR.Repository.Interface
{
    public interface IGenericRepository<TEnt> where TEnt : class
    {
        IEnumerable<TEnt> GetAll();
        TEnt Get(object id);
        IEnumerable<TEnt> Find(Expression<Func<TEnt, bool>> predicate);
        
        void Add(TEnt entity);

        void Remove(TEnt entity);
        
    }    
}
