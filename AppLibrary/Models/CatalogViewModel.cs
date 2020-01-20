using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class CatalogViewModel
    {
        public string LibraryName { get; set; }
        public List<BookViewModel> BooksList { get; set; }

        public CatalogViewModel(string libraryName, List<BookViewModel> booksList)
        {
            LibraryName = libraryName;
            BooksList = booksList;
        }

        }
}
