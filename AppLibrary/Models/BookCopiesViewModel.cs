using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class BookCopiesViewModel
    {
        public int Id { get; set; }
        public int NumberOfCopies { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Library> Libraries { get; set; }
        public BookCopies BookCopies { get; set; }


    }
}
