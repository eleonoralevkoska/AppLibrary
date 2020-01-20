using AppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.BusinessLayer
{
    public interface IClientService
    {
        ClientViewModel GetClient(string email, string password);
        ClientViewModel GetClientByEmail(string email);
    }
}
