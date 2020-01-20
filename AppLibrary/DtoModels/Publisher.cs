using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DtoModels
{
    public class Publisher : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public ICollection<Book> Books { get; set; }

        public Publisher() { }

        public Publisher(string name, string country)
        {
            Name = name;
            Country = country;
        }
    }
}
