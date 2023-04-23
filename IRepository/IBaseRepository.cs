using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Repository
{
    public interface IBaseRepository<T> where T : class 
    {
        T GetByID(int id);

        IEnumerable<T> GetAll();

        T Find(Expression<Func<T, bool>> match);

        T? Upsert(int? id, T entity);

        T? Upsert(int? id);

        T? Details(int? id);

        T? Delete(int? id);

        T? Index();

        List<object> GetQuery(Expression<Func<T, bool>> filter = null,Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,string includeProperties = "");
    }
    
}

