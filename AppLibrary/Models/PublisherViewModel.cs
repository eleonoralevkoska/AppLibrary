using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class PublisherViewModel
    {
        public int Id { get; set; }
        public Publisher Publisher { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
