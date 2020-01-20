using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public interface ILibraryRepository : IRepository<Library>
    {

        IEnumerable<Library> GetAllLibrariesWithBooks();
    }
}
