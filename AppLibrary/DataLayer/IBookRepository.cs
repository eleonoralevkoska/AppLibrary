using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetAllWithPublisher();

        IEnumerable<Book> FindWithPublisher(Func<Book, bool> predicate);
    }
}
