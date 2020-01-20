using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class LendingViewModel
    {
        public int Id { get; set; }        
        public string DateOfLending { get; set; }
        public string DateOfReturning { get; set; }
        public Lending Lending { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
