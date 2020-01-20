using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DtoModels
{
    public class BookCopies : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int NumberOfCopies { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; }

        public BookCopies() { }
        public BookCopies(int bookid,int numberofcopies, int libraryid)
        {
            BookId = bookid;
            NumberOfCopies = numberofcopies;
            LibraryId = libraryid;
        }
    }
}
