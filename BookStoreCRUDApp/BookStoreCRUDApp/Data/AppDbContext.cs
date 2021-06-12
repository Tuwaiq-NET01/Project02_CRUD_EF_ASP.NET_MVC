using BookStoreCRUDApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCRUDApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //add book table 
        public DbSet<BookModel> Books { get; set; }
        //add author table
        public DbSet<AuthorModel> Authors { get; set; }

        //add book store table 
        public DbSet<BookStoreModel> BookStore { get; set; }

        public DbSet<Book_Author> BookAuthor { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            // Seeding  book data into DB
            modelBuilder.Entity<BookModel>().HasData(new BookModel { BookID = 1, Title = "Opertaing System", Price = 103.5f, NoPage = 530, Notes = "Good Book !", IdBookStore = 1 });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { BookID = 2, Title = "Data Structure", Price = 99.5f, NoPage = 400, Notes = "boring book", IdBookStore = 1 });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { BookID = 3, Title = "Software Testing", Price = 300.5f, NoPage = 500, Notes = "Interesting book", IdBookStore = 1 });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { BookID = 4, Title = "Design Pattren", Price = 200.9f, NoPage = 300, Notes = "boring book", IdBookStore = 2 });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { BookID = 5, Title = "Learn How To Learn", Price = 90.5f, NoPage = 250, Notes = "A very useful book", IdBookStore = 2 });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { BookID = 6, Title = "Act Like A Success", Price = 88.5f, NoPage = 100, Notes = "Interesting book", IdBookStore = 2 });


            // Seeding  author data into DB
            modelBuilder.Entity<AuthorModel>().HasData(new AuthorModel { AuthorID = 1, AuthorFirstName = "Andrea", AuthorLastName = "Arbasi", AuthorEmail = "Andrea@mail.com", Notes = "This author has written great" });
            modelBuilder.Entity<AuthorModel>().HasData(new AuthorModel { AuthorID = 2, AuthorFirstName = "Jan", AuthorLastName = "Wengro", AuthorEmail = "Jan@mail.com", Notes = "This author has written great" });
            modelBuilder.Entity<AuthorModel>().HasData(new AuthorModel { AuthorID = 3, AuthorFirstName = "Pon", AuthorLastName = "Pattren", AuthorEmail = "Pon@mail.com", Notes = "This author has written great" });
            modelBuilder.Entity<AuthorModel>().HasData(new AuthorModel { AuthorID = 4, AuthorFirstName = " Alexander", AuthorLastName = "Jony", AuthorEmail = "Alexander@mail.com", Notes = "This author has written great" });
            modelBuilder.Entity<AuthorModel>().HasData(new AuthorModel { AuthorID = 5, AuthorFirstName = "Mikel", AuthorLastName = "Jon", AuthorEmail = "Mikel@mail.com", Notes = "This author has written great" });
            modelBuilder.Entity<AuthorModel>().HasData(new AuthorModel { AuthorID = 6, AuthorFirstName = " Murray", AuthorLastName = "Silverstein", AuthorEmail = "Murray@mail.com", Notes = "This author has written great" });



            //Seeding  bookstore into DB
            modelBuilder.Entity<BookStoreModel>().HasData(new BookStoreModel { IdBookStore = 1, NameOfBookStore = " Jarir", Location = "Al-Hamra-Riyadh", EmailOfBookStore = "bs-r@mail.com", Telephone = "011984430" });
            modelBuilder.Entity<BookStoreModel>().HasData(new BookStoreModel { IdBookStore = 2, NameOfBookStore = " Jarir", Location = "Al-Manar-Jeddah", EmailOfBookStore = "bs-j@mail.com", Telephone = "01488994" });




            /*            modelBuilder.Entity<Book_Author>().HasKey(ba => new { ba.BookID, ba.AuthorID });*/
            // seeding Book Author Table Many To Many 
            var bookauthor = new[]
            {
                         new Book_Author{BAId=1 ,BookID=1, AuthorID=1},
                         new Book_Author{BAId=2 ,BookID=2, AuthorID=2},
                          // Author with id 3 related with book id 1 
                           new Book_Author{BAId=3,BookID=1, AuthorID=3}

                         };
            modelBuilder.Entity<Book_Author>().HasData(bookauthor);

        }

    }
}
