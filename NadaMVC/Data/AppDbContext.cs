using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NadaMVC.Models;

namespace NadaMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookModel>().HasData(new BookModel(1, "Roald Dahl", "The BFG", 1982, "https://upload.wikimedia.org/wikipedia/ar/thumb/b/b2/The_BFG_%28Dahl_novel_-_cover_art%29.jpg/227px-The_BFG_%28Dahl_novel_-_cover_art%29.jpg"));
            modelBuilder.Entity<BookModel>().HasData(new BookModel(2, "Jeff Kinney", "Diary of a Wimpy Kid", 2007, "https://upload.wikimedia.org/wikipedia/ar/0/09/Diary_of_a_wimpy_kid.jpg"));
            modelBuilder.Entity<BookModel>().HasData(new BookModel(3, "Antoine De Saint", "The Little Prince", 2016, "https://images-na.ssl-images-amazon.com/images/I/4186P0mACWL._SX336_BO1,204,203,200_.jpg"));
            modelBuilder.Entity<BookModel>().HasData(new BookModel(4, "Markus Zusak", "The Book Thief", 2016, "https://images-na.ssl-images-amazon.com/images/I/41LxDicrz2L._SX334_BO1,204,203,200_.jpg"));
            modelBuilder.Entity<BookModel>().HasData(new BookModel(5, "Gareth Moore", "Brain Games for Clever Kids", 2014, "https://images-na.ssl-images-amazon.com/images/I/51WAKxhIoyL._SX328_BO1,204,203,200_.jpg"));
            modelBuilder.Entity<BookModel>().HasData(new BookModel (7,"Simon","Programming",2021, "https://images-na.ssl-images-amazon.com/images/I/71d-G-ihrTL.jpg"));

        }

        public DbSet<BookModel> Book { get; set; }
        public DbSet<BooksSellerModel> BookSeller { get; set; }
    }
}