using AppLibrary.DataLayer;
using AppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.BusinessLayer
{
    public class ClientService : IClientService
    {

        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        

        public ClientViewModel GetClient(string email, string password)
        {
            var user = _clientRepository.GetAll().FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null)
                return null;

            return new ClientViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Address = user.Address,
                Phone = user.Phone,
                Name = user.Name
            };
        }

        public ClientViewModel GetClientByEmail(string email)
        {
            var user = _clientRepository.GetAll().FirstOrDefault(x => x.Email == email);

            if (user == null)
                throw new Exception("User does not exist.");

            return new ClientViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Address = user.Address,
                Phone = user.Phone,
                Name = user.Name
            };
        }


    }
}
