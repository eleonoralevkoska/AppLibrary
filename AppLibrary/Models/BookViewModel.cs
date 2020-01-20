using AppLibrary.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public string Title { get; set; }
        public string YearOfIssue { get; set; }
        public int NumberOfPages { get; set; }
        public IEnumerable<Publisher> Publishers { get; set; }
    }
}
