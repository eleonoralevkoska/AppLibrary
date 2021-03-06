﻿// <auto-generated />
using AppLibrary.DtoModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppLibrary.Migrations
{
    [DbContext(typeof(AppLibraryDbContext))]
    partial class AppLibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppLibrary.DtoModels.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfPages");

                    b.Property<int>("PublisherId");

                    b.Property<string>("Title");

                    b.Property<string>("YearOfIssue");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NumberOfPages = 30,
                            PublisherId = 1,
                            Title = "Book1",
                            YearOfIssue = "11.11.2011"
                        },
                        new
                        {
                            Id = 2,
                            NumberOfPages = 40,
                            PublisherId = 2,
                            Title = "Book2",
                            YearOfIssue = "11.12.2012"
                        });
                });

            modelBuilder.Entity("AppLibrary.DtoModels.BookCopies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<int>("LibraryId");

                    b.Property<int>("NumberOfCopies");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("LibraryId");

                    b.ToTable("BookCopies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            LibraryId = 1,
                            NumberOfCopies = 15
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            LibraryId = 2,
                            NumberOfCopies = 20
                        });
                });

            modelBuilder.Entity("AppLibrary.DtoModels.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Address1",
                            City = "Skopje",
                            Email = "eleonora@hotmail.com",
                            Name = "Eleonora",
                            Password = "123456",
                            Phone = "389111111"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Address2",
                            City = "Skopje",
                            Email = "ana@hotmai.com",
                            Name = "Ana",
                            Password = "654321",
                            Phone = "3892222222"
                        });
                });

            modelBuilder.Entity("AppLibrary.DtoModels.Lending", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<int>("ClientId");

                    b.Property<string>("DateOfLending");

                    b.Property<string>("DateOfReturning");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ClientId");

                    b.ToTable("Lendings");
                });

            modelBuilder.Entity("AppLibrary.DtoModels.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Adress1",
                            City = "Skopje",
                            Name = "Library1"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Adress2",
                            City = "Skopje",
                            Name = "Library2"
                        });
                });

            modelBuilder.Entity("AppLibrary.DtoModels.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Country1",
                            Name = "Publisher1"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Country2",
                            Name = "Publisher2"
                        });
                });

            modelBuilder.Entity("AppLibrary.DtoModels.Book", b =>
                {
                    b.HasOne("AppLibrary.DtoModels.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AppLibrary.DtoModels.BookCopies", b =>
                {
                    b.HasOne("AppLibrary.DtoModels.Book", "Book")
                        .WithMany("BookCopies")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppLibrary.DtoModels.Library", "Library")
                        .WithMany("BookCopies")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AppLibrary.DtoModels.Lending", b =>
                {
                    b.HasOne("AppLibrary.DtoModels.Book", "Book")
                        .WithMany("Lendings")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppLibrary.DtoModels.Client", "Client")
                        .WithMany("Lendings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
