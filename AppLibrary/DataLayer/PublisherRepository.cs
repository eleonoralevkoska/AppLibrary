using AppLibrary.DtoModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public class PublisherRepository : Repository<Publisher>, IPublisherRepository
    {
        public PublisherRepository(AppLibraryDbContext context) : base(context)
        {
        }

        public IEnumerable<Publisher> GetAllWithBooks()
        {
            return _context.Publishers.Include(a => a.Books);
        }

        public Publisher GetWithBooks(int id)
        {
            return _context.Publishers
                .Where(a => a.Id == id)
                .Include(a => a.Books)
                .FirstOrDefault();
        }       
    }
}

