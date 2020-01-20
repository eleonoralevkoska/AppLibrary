using AppLibrary.DtoModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public class BookCopiesRepository : Repository<BookCopies>, IBookCopiesRepository
    {
        public BookCopiesRepository(AppLibraryDbContext context) : base(context)
        {
        }

        public IEnumerable<BookCopies> GetAllBookCopiesWithBooks()
        {
            return _context.BookCopies.Include(a => a.Book).Include(x=>x.Library);
        }
    }
}
