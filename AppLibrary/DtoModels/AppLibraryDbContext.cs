using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLibrary.DtoModels
{
    public class AppLibraryDbContext : DbContext
    {

        public AppLibraryDbContext(DbContextOptions<AppLibraryDbContext> options)
            : base(options)
        {
        }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Lending> Lendings { get; set; }
        public DbSet<BookCopies> BookCopies { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCopies>()
                .HasOne(x => x.Library)
                .WithMany(x => x.BookCopies)
                .HasForeignKey(x => x.LibraryId);

            modelBuilder.Entity<BookCopies>()
                .HasOne(x => x.Book)
                .WithMany(x => x.BookCopies)
                .HasForeignKey(x => x.BookId);

            modelBuilder.Entity<Book>()
                .HasOne(x => x.Publisher)
                .WithMany(x => x.Books)
                .HasForeignKey(x=>x.PublisherId);          

            modelBuilder.Entity<Lending>()
                .HasOne(x => x.Book)
                .WithMany(x => x.Lendings)
                .HasForeignKey(x => x.BookId);           

            modelBuilder.Entity<Lending>()
                .HasOne(x => x.Client)
                .WithMany(x => x.Lendings)
                .HasForeignKey(x => x.ClientId);

            #region seed
            var books = new List<Book>
            {
                new Book("Book1","11.11.2011",30,1){ Id=1},
                new Book("Book2","11.12.2012",40,2){ Id=2}
            };

            var libraries = new List<Library>
            {
                new Library("Library1","Adress1","Skopje"){ Id=1},
                new Library("Library2","Adress2","Skopje"){ Id=2}
            };

            var publishers = new List<Publisher>
            {
                new Publisher("Publisher1","Country1"){ Id=1},
                new Publisher("Publisher2","Country2"){ Id=2}
            };

            var clients = new List<Client>
            {
                new Client("Eleonora","389111111","Address1","Skopje", "eleonora@hotmail.com","123456" ){ Id=1},
                new Client("Ana","3892222222","Address2","Skopje","ana@hotmai.com","654321"){ Id=2}
            };

            var bookcopies = new List<BookCopies>
            {
                new BookCopies(1,15,1 ){ Id=1},
                new BookCopies(2,20,2){ Id=2}
            };

            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.Entity<Library>().HasData(libraries);
            modelBuilder.Entity<Publisher>().HasData(publishers);
            modelBuilder.Entity<Client>().HasData(clients);
            modelBuilder.Entity<BookCopies>().HasData(bookcopies);
            #endregion
        }
    }
}
