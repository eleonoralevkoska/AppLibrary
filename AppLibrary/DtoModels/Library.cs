using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DtoModels
{
    public class Library : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public ICollection<BookCopies> BookCopies { get; set; }

        public Library() { }
        public Library(string name, string address, string city)
        {
            Id = Id;
            Name = name;
            Address = address;
            City = city;
        }
    }

}
