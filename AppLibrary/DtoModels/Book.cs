using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DtoModels
{
    public class Book : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string YearOfIssue { get; set; }
        public int NumberOfPages { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<BookCopies> BookCopies { get; set; }
        public ICollection<Lending> Lendings { get; set; }
        

        public Book() { }
        public Book(string title, string yearofissue, int numberOfPages, int publisherId)
        {
            Title = title;
            YearOfIssue = yearofissue;
            NumberOfPages = numberOfPages;
            PublisherId = publisherId;           
        }
    }
}
