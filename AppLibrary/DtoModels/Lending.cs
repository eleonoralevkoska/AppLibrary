using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DtoModels
{
    public class Lending : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string DateOfLending { get; set; }
        public string DateOfReturning { get; set; }

        public Lending() { }
        public Lending(int bookId,int clientId,string dateOfLending,string dateOfReturning)
        {
            BookId = bookId;
            ClientId = clientId;
            DateOfLending = dateOfLending;
            DateOfReturning = dateOfReturning;
        }
    }
}
