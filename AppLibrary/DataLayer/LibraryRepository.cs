using AppLibrary.DtoModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public class LibraryRepository : Repository<Library>, ILibraryRepository
    {
        public LibraryRepository(AppLibraryDbContext context) : base(context)
        {
        }            

        public IEnumerable<Library> GetAllLibrariesWithBooks()
        {
            return _context.Libraries.Include(a => a.BookCopies);
        }
    }
}
