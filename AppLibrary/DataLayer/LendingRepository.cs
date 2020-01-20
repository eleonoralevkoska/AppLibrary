using AppLibrary.DtoModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public class LendingRepository : Repository<Lending>, ILendingRepository
    {
        //private AppLibraryDbContext _context;
        public LendingRepository(AppLibraryDbContext context) : base(context)
        {
        }

        public IEnumerable<Lending> GetAllWithClientandBook()
        {
            return _context.Lendings.Include(a => a.Client).Include(x => x.Book);
        }


    }
}
