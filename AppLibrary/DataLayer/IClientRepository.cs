using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DataLayer
{
    public interface IClientRepository : IRepository<Client>
    {
        IEnumerable<Client> GetAllWithLendings();
    }
}
