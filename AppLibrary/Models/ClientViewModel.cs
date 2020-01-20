using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { set; get; }
        public string City { get; set; }
        public Client Client { get; set; }
        public IEnumerable<Lending> Lendings { get; set; }

        public string Email { get; set; }        
    }
}
