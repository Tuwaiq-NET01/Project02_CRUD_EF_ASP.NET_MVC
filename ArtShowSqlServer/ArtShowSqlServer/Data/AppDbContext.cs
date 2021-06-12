using ArtShowSqlServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShowSqlServer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        //Tables
        public DbSet<UsersModel> Users { get; set; }
        public DbSet<ProfileModel> Profile { get; set; }
        public DbSet<ArtWorksModel> ArtWorks { get; set; }
        public DbSet<ArtsitsModel> Artsits { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {    // Data User Table
            modelBuilder.Entity<UsersModel>().HasData(new UsersModel { Id = 1, Username = "shahad123", Password = "0987" });
            modelBuilder.Entity<UsersModel>().HasData(new UsersModel { Id = 2, Username = "ali123", Password = "1234" });
            modelBuilder.Entity<UsersModel>().HasData(new UsersModel { Id = 3, Username = "sara123", Password = "5678" });

            //Art works
            modelBuilder.Entity<ArtWorksModel>().HasData(new ArtWorksModel
            { Id = 1, Title = "African Girl", Image = "https://arabartforsale.com/uploads/artworks/1621526489_file.jpeg", Price = 350, ArtsitId = 2 });
            modelBuilder.Entity<ArtWorksModel>().HasData(new ArtWorksModel
            { Id = 2, Title = "Beach Girl", Image = "https://i.pinimg.com/564x/19/75/d6/1975d6e559da17936176eb6168161089.jpg", Price = 400, ArtsitId = 4 });
            modelBuilder.Entity<ArtWorksModel>().HasData(new ArtWorksModel
            { Id = 3, Title = "Health Heroes", Image = "https://i.pinimg.com/564x/b5/97/59/b597595d747bde7c979c9e4a37e2c674.jpg", Price = 450, ArtsitId = 4 });
            modelBuilder.Entity<ArtWorksModel>().HasData(new ArtWorksModel
            { Id = 4, Title = "Peace", Image = "https://i.pinimg.com/564x/ef/6b/11/ef6b11c49ea530a0420252f6defb8904.jpg", Price = 500, ArtsitId = 3 });
            modelBuilder.Entity<ArtWorksModel>().HasData(new ArtWorksModel
            { Id = 5, Title = "Mditate Look", Image = "https://i.pinimg.com/564x/16/e4/64/16e464c0cab9851c52eed6688889bc25.jpg", Price = 550, ArtsitId = 3 });
            modelBuilder.Entity<ArtWorksModel>().HasData(new ArtWorksModel
            { Id = 6, Title = "Playing Music", Image = "https://i.pinimg.com/564x/0d/e5/54/0de554e7bdb9b876fd7a7138c70cdb2c.jpg", Price = 600, ArtsitId = 2 });
            modelBuilder.Entity<ArtWorksModel>().HasData(new ArtWorksModel
            { Id = 7, Title = "Look Of Hope", Image = " https://i.pinimg.com/564x/da/b4/83/dab483b7b0e472a8777ab008bb06dba3.jpg", Price = 650, ArtsitId = 1 });
            modelBuilder.Entity<ArtWorksModel>().HasData(new ArtWorksModel
            { Id = 8, Title = "Flower Girl", Image = "https://i.pinimg.com/564x/b6/97/25/b6972560735a5eccba28aab8cf37dd92.jpg", Price = 700, ArtsitId = 2 });
            modelBuilder.Entity<ArtWorksModel>().HasData(new ArtWorksModel
            { Id = 9, Title = "Playing Music", Image = "https://i.pinimg.com/474x/24/f9/54/24f9540c894b2756ff42dc0f8dbf2f76.jpg", Price = 750, ArtsitId = 1 });

            //Artist
            modelBuilder.Entity<ArtsitsModel>().HasData(new ArtsitsModel
            { Id = 1, Name = "Mousa Fahad ", NumberPhone = 0553478768 });
            modelBuilder.Entity<ArtsitsModel>().HasData(new ArtsitsModel
            { Id = 2, Name = " Afnan Ali", NumberPhone = 050754676 });
            modelBuilder.Entity<ArtsitsModel>().HasData(new ArtsitsModel
            { Id = 3, Name = "Amal Alshehri", NumberPhone = 0557779835 });
            modelBuilder.Entity<ArtsitsModel>().HasData(new ArtsitsModel
            { Id = 4, Name = "Hassan Khiled", NumberPhone = 053769487 });

            //Profile User
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel
            { Id = 1, First_Name = "Shahad", Last_Name = "Alshehri", Gender = "Female", Phone_Number = 0503664482, UserId = 1 });
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel
            { Id = 2, First_Name = "Ali", Last_Name = "Hassan", Gender = "Male", Phone_Number = 0553388292, UserId = 2 });
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel
            { Id = 3, First_Name = "sara", Last_Name = "Ali", Gender = "Female", Phone_Number = 0508194230, UserId = 3 });

        }

    }

    }

