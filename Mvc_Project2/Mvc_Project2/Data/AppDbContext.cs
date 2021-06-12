using Microsoft.EntityFrameworkCore;
using Mvc_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Project2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PassengerModel> passengers { get; set; }
        public DbSet<PlaneModel> Planes { get; set; }
        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<BagModel> Bags { get; set; }



        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PlaneModel>().HasData(new PlaneModel { Id = 1, Name = "Plane 01", Airlines = "Saudi Arabian Airlines" });
            modelBuilder.Entity<PlaneModel>().HasData(new PlaneModel { Id = 2, Name = "Plane 02", Airlines = "Emirates" });
            modelBuilder.Entity<PlaneModel>().HasData(new PlaneModel { Id = 3, Name = "Plane 03", Airlines = "Etihad Airways" });
            modelBuilder.Entity<PlaneModel>().HasData(new PlaneModel { Id = 4, Name = "Plane 04", Airlines = "Emirates" });

            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel { Id = 1, Name = "Mohammed", Email = "Mohammed@gmail.com", PhoneNum = "0599334453", PlaneId = 1 });
            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel { Id = 2, Name = "Ali", Email = "Ali@gmail.com", PhoneNum = "0590834453", PlaneId = 1 });
            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel { Id = 3, Name = "Hassan", Email = "Hassan@gmail.com", PhoneNum = "0504534231", PlaneId = 2 });
            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel { Id = 4, Name = "Fahad", Email = "Fahad@gmail.com", PhoneNum = "0503625499", PlaneId = 2 });
            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel { Id = 5, Name = "Anas", Email = "Anas@gmail.com", PhoneNum = "0504422453", PlaneId = 3 });
            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel { Id = 6, Name = "Hamad", Email = "Hamad@gmail.com", PhoneNum = "0500983324", PlaneId = 3 });
            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel { Id = 7, Name = "Ahmed", Email = "Ahmed@gmail.com", PhoneNum = "0599432343", PlaneId = 4 });
            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel { Id = 8, Name = "Meshal", Email = "Meshal@gmail.com", PhoneNum = "0555098833", PlaneId = 4 });


            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { Id = 1, Name = "United States", Flag = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/1920px-Flag_of_the_United_States.svg.png", Language = "English" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { Id = 2, Name = "United Arab Emirates", Flag = "https://th.bing.com/th/id/R9577060d3d8e2986295e430747ba0a65?rik=c%2fwkgwj3Y6S3wA&pid=ImgRaw", Language = "Arabic" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { Id = 3, Name = "Egypt", Flag = "https://th.bing.com/th/id/R0539c85b1aa77d7ecaac44873dc281d0?rik=sCwObasiJojamA&pid=ImgRaw", Language = "Arabic" });
            
            
            
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 1, Color="red", Size = "small",PassengerId=1});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 2, Color="black", Size = "big",PassengerId=1});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 3, Color="red", Size = "big",PassengerId=2});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 4, Color="black", Size = "small",PassengerId=3});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 5, Color="red", Size = "big",PassengerId=3});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 6, Color="white", Size = "small",PassengerId=4});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 7, Color= "brouwn", Size = "small",PassengerId=6});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 8, Color="black", Size = "big",PassengerId=5});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 9, Color="black", Size = "big",PassengerId=7});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 10, Color="pink", Size = "small",PassengerId=8});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 11, Color="white", Size = "big",PassengerId=8});
            modelBuilder.Entity<BagModel>().HasData(new BagModel{ Id = 12, Color= "brouwn", Size = "small",PassengerId=2});

        }
    }
}
