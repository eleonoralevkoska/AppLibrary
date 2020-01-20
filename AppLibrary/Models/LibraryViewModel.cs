using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class LibraryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public ICollection<BookCopies> BookCopies { get; set; }
        public Library Library { get; set; }
    }
}
