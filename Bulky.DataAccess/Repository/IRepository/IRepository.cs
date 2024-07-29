using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
     public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null, string? inclueProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? inclueProperties = null, bool tracked = false);
        void Add(T entity);
        void Remove(T entity);
        void ReomveRange(IEnumerable<T> entity);

    }
}
