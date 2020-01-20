using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DtoModels
{
    public class Client : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { set; get; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Lending> Lendings { get; set; }

        public Client() { }
        public Client(string name, string phone, string address, string city,string email,string password)
        {
            Name = name;
            Phone = phone;
            Address = address;
            City = city;
            Email = email;
            Password = password;

        }
    }
}
