using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public interface IRepository<T>
    {
        //IEnumerable<T> GetAll();

        List<T> GetAll(Func<IQueryable<T>, IQueryable<T>> func = null);

        IEnumerable<T> Find(Func<T, bool> predicate);

        T GetById(int id);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        int Count(Func<T, bool> predicate);

    }
}
