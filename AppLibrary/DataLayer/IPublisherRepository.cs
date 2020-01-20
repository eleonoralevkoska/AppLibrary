using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public interface IPublisherRepository : IRepository<Publisher>
    {
        IEnumerable<Publisher> GetAllWithBooks();
        Publisher GetWithBooks(int id);
    }
}
