using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using CRUD_Project.Models;

namespace CRUD_Project.Data
{

    public class AppDbContext: DbContext
    {
        public DbSet<BookModel> Books { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 1, Name = "Introductory Nuclear Physics", Author = "Kenneth S Krane", ImageSrc = "https://m.media-amazon.com/images/I/41QiRwidJJL.jpg" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 2, Name = "Essentials of Computer Architecture 2nd Edition", Author = "Douglas Comer", ImageSrc = "https://images-na.ssl-images-amazon.com/images/I/513ShlaCsTL._SX384_BO1,204,203,200_.jpg" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 3, Name = "You Don't Know JS Yet: Get Started", Author = "Kyle Simpson", ImageSrc = "https://images-na.ssl-images-amazon.com/images/I/41vNUw5VbPL._SX398_BO1,204,203,200_.jpg" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 4, Name = "CLR via C#", Author = "Jeffrey Richter", ImageSrc = "https://images-na.ssl-images-amazon.com/images/I/41IgijxpDhL._SX408_BO1,204,203,200_.jpg" });
        }
    }
}
