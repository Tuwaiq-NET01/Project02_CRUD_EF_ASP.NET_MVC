using System;
using Microsoft.EntityFrameworkCore;
using third_project_.Models;

namespace third_project_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<QuotationModel> Quotations { get; set; }
        public DbSet<StudentModel> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //seeding Studens
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 1, Name = "Afra "});
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 2, Name = "Yara " });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 3, Name = "maram " });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 4, Name = "manar " });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 5, Name = "duaa " });

            //seeding Studens
            modelBuilder.Entity<QuotationModel>().HasData(new QuotationModel { Id = 1, Message = " There is nothing permanent except change.", StudentId = 1  });
            modelBuilder.Entity<QuotationModel>().HasData(new QuotationModel { Id = 2, Message = " When you reach the end of your rope, tie a knot in it and hang on.", StudentId = 1 });
            modelBuilder.Entity<QuotationModel>().HasData(new QuotationModel { Id = 3, Message = " Learning never exhausts the mind.", StudentId = 2 });
            modelBuilder.Entity<QuotationModel>().HasData(new QuotationModel { Id = 4, Message = " All that we see or seem is but a dream within a dream.", StudentId = 3 });
            modelBuilder.Entity<QuotationModel>().HasData(new QuotationModel { Id = 5, Message = " No act of kindness, no matter how small, is ever wasted.", StudentId = 4 });
            modelBuilder.Entity<QuotationModel>().HasData(new QuotationModel { Id = 6, Message = " It is far better to be alone, than to be in bad company.", StudentId = 4 });
            modelBuilder.Entity<QuotationModel>().HasData(new QuotationModel { Id = 7, Message = " If you cannot do great things, do small things in a great way.", StudentId = 5 });
            modelBuilder.Entity<QuotationModel>().HasData(new QuotationModel { Id = 8, Message = " Keep your face always toward the sunshine - and shadows will fall behind you.", StudentId = 1  });


        }
    }
}
