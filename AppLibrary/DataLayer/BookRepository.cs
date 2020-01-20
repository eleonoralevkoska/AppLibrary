using AppLibrary.DtoModels;
using AppLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        //private AppLibraryDbContext _context;
        public BookRepository(AppLibraryDbContext context) : base(context)
        {
        }
        public IEnumerable<Book> FindWithPublisher(Func<Book, bool> predicate)
        {
            return _context.Books
                .Include(a => a.Publisher)
                .Where(predicate);
        }

        public int Insert(Book entity)
        {
            _context.Books.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }     

        public IEnumerable<Book> GetAllWithPublisher()
        {
            return _context.Books.Include(a => a.Publisher);
        }

    }
}
