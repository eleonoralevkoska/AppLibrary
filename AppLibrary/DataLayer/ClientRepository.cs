using AppLibrary.DtoModels;
using AppLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(AppLibraryDbContext context) : base(context)
        {
        }

        public IEnumerable<Client> GetAllWithLendings()
        {
            return _context.Clients.Include(a=>a.Lendings);
        }
    }
}
