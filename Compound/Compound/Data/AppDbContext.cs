using Microsoft.EntityFrameworkCore;
using System;
using Compound.Models;

namespace Compound.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<StaffModel> Staff { get; set; }
        public DbSet<VilladModel> Villa { get; set; }
        public DbSet<ServiceModel> Services { get; set; }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<Merchent> Merchents { get; set; }
        // public DbSet<User_EventModel> Users_Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Merchent
            modelBuilder.Entity<Merchent>().HasData(new Merchent {Id=1, Name="Toy",Description="Bunny toy",Price=12.2 });
            modelBuilder.Entity<Merchent>().HasData(new Merchent { Id = 2, Name = "Toy", Description = "Princesses toy", Price = 102.2 });
            modelBuilder.Entity<Merchent>().HasData(new Merchent { Id = 3, Name = "Car", Description = "Truck toy", Price = 212.2 });
            modelBuilder.Entity<Merchent>().HasData(new Merchent { Id = 4, Name = "Jengo", Description = "Blocks to be destroyed", Price = 132.2 });


            //Users
            modelBuilder.Entity<UserModel>().HasData(new UserModel { User_Id = 1, User_Name = "Abdulrahman", User_Email = "ControlS@gmail.com", User_PhoneNumber = "0560965772", VillaId = 1 });
            modelBuilder.Entity<UserModel>().HasData(new UserModel { User_Id = 2, User_Name = "Ahmad", User_Email = "Ahmad@gmail.com", User_PhoneNumber = "0512312345", VillaId = 1 });
            modelBuilder.Entity<UserModel>().HasData(new UserModel { User_Id = 3, User_Name = "Anas", User_Email = "Anas@gmail.com", User_PhoneNumber = "0567324545", VillaId = 1 });
            modelBuilder.Entity<UserModel>().HasData(new UserModel { User_Id = 4, User_Name = "Sarah", User_Email = "Sarah@gmail.com", User_PhoneNumber = "0555333642", VillaId = 2 });
            modelBuilder.Entity<UserModel>().HasData(new UserModel { User_Id = 5, User_Name = "Amjad", User_Email = "Amjad@gmail.com", User_PhoneNumber = "0553366990", VillaId = 2 });

            //Event
            modelBuilder.Entity<EventModel>().HasData(new EventModel { Event_Id = 1, Event_Name = "Musical concert", Event_Date = new DateTime(2021, 11, 01), StaffId = 2 });
            modelBuilder.Entity<EventModel>().HasData(new EventModel { Event_Id = 2, Event_Name = "Gamming Event", Event_Date = new DateTime(2021, 01, 01), StaffId = 5 });
            modelBuilder.Entity<EventModel>().HasData(new EventModel { Event_Id = 3, Event_Name = "Musical Event", Event_Date = new DateTime(2022, 10, 20), StaffId= 3 });
            modelBuilder.Entity<EventModel>().HasData(new EventModel { Event_Id = 4, Event_Name = "Hackthon", Event_Date = new DateTime(2021, 08, 05) ,StaffId=4});
            modelBuilder.Entity<EventModel>().HasData(new EventModel { Event_Id = 5, Event_Name = "Otaku Event", Event_Date = new DateTime(2021, 11, 04) ,StaffId=2});

            //Services
            modelBuilder.Entity<ServiceModel>().HasData(new ServiceModel { Service_Id = 1, Service_Name = "Clean the swimming pool", StaffId = 4 });
            modelBuilder.Entity<ServiceModel>().HasData(new ServiceModel { Service_Id = 2, Service_Name = "Preparing the basketball ground play", StaffId = 4 });
            modelBuilder.Entity<ServiceModel>().HasData(new ServiceModel { Service_Id = 3, Service_Name = "InVilla Service", StaffId = 3 });
            modelBuilder.Entity<ServiceModel>().HasData(new ServiceModel { Service_Id = 4, Service_Name = "Massage", StaffId = 3 });
            modelBuilder.Entity<ServiceModel>().HasData(new ServiceModel { Service_Id = 5, Service_Name = "Whatever", StaffId = 3 });


            //Staff
            modelBuilder.Entity<StaffModel>().HasData(new StaffModel { Staff_Id = 1, Staff_Name = "Mohammad", Staff_Email = "MohammadS@gmail.com", Staff_PhoneNumber = "0560908070", Staff_AtWork = true,UserId=4, Staff_Img = "https://content.api.news/v3/images/bin/7b790c831c72c5dd3b3275833df09f29" });
            modelBuilder.Entity<StaffModel>().HasData(new StaffModel { Staff_Id = 2, Staff_Name = "Jhon", Staff_Email = "JhonS@gmail.com", Staff_PhoneNumber = "0576855421", Staff_AtWork = true,UserId=1, Events = { }, Services = { }, Staff_Img = "https://cdn-0.generatormix.com/images/anime-character/death-the-kid.jpg" });
            modelBuilder.Entity<StaffModel>().HasData(new StaffModel { Staff_Id = 3, Staff_Name = "Alice", Staff_Email = "AliceS@gmail.com", Staff_PhoneNumber = "0567431473", Staff_AtWork = true, UserId = 3, Events = { }, Services = { }, Staff_Img = "https://animerantshome.files.wordpress.com/2019/08/istj-anime-characters-akame-ga-kill.png?w=600" });
            modelBuilder.Entity<StaffModel>().HasData(new StaffModel { Staff_Id = 4, Staff_Name = "Tony", Staff_Email = "TonyS@gmail.com", Staff_PhoneNumber = "0576524582", Staff_AtWork = true, UserId = 3, Events = { }, Services = { }, Staff_Img = "https://static.fandomspot.com/images/11/10193/00-featured-killua-zoldyck-hunter-x-hunter-anime-preview.jpg" });
            modelBuilder.Entity<StaffModel>().HasData(new StaffModel { Staff_Id = 5, Staff_Name = "Jasmin", Staff_Email = "JasminS@gmail.com", Staff_PhoneNumber = "0500011123", Staff_AtWork = true,UserId=2, Events = { }, Services = { }, Staff_Img = "https://vignette.wikia.nocookie.net/akamegakill/images/6/62/Jaegers5.png/revision/latest?cb=20150720195115&path-prefix=ru" });



            //Villa
            modelBuilder.Entity<VilladModel>().HasData(new VilladModel
            {
                Villa_Id = 1,
                Villa_Number = 1,
                Villa_Name = "Al-Azhar",
                Villa_Group = "A",
                User = { },
                Villa_Img = "https://q-xx.bstatic.com/images/hotel/max1024x768/163/163300408.jpg"
            });
            modelBuilder.Entity<VilladModel>().HasData(new VilladModel
            {
                Villa_Id = 2,
                Villa_Number = 2,
                Villa_Name = "Al-Khair",
                Villa_Group = "A",
                User = { },
                Villa_Img = "https://cf.bstatic.com/images/hotel/max1024x768/256/256451213.jpg"
            });
            modelBuilder.Entity<VilladModel>().HasData(new VilladModel { Villa_Id = 3, Villa_Number = 3, Villa_Name = "Al-Khaliej", Villa_Group = "B", User = { }, Villa_Img = "https://assets.entrepreneur.com/content/3x2/2000/1604135072-webaliser--TPTXZd9mOo-unsplash.jpg" });
            modelBuilder.Entity<VilladModel>().HasData(new VilladModel { Villa_Id = 4, Villa_Number = 4, Villa_Name = "Al-Rabea", Villa_Group = "C", User = { }, Villa_Img = "https://images.traum-ferienwohnungen.de/277125/8501414/46/villa-blanka.jpg" });
            modelBuilder.Entity<VilladModel>().HasData(new VilladModel { Villa_Id = 33, Villa_Number = 5, Villa_Name = "Al-Hamdanyah", Villa_Group = "D", User = { }, Villa_Img = "https://images.traum-ferienwohnungen.de/266108/7923121/46/villa-1.jpg" });



            //user-event model
            /*modelBuilder.Entity<User_EventModel>().HasData(new User_EventModel { Id = 1, User = { }, UserId = 1, Event = { }, EventId = 2 });
            modelBuilder.Entity<User_EventModel>().HasData(new User_EventModel { Id = 2, User = { }, UserId = 2, Event = { }, EventId = 1 });
            modelBuilder.Entity<User_EventModel>().HasData(new User_EventModel { Id = 3, User = { }, UserId = 3, Event = { }, EventId = 3 });
            modelBuilder.Entity<User_EventModel>().HasData(new User_EventModel { Id = 4, User = { }, UserId = 4, Event = { }, EventId = 5 });
            modelBuilder.Entity<User_EventModel>().HasData(new User_EventModel { Id = 5, User = { }, UserId = 5, Event = { }, EventId = 4 });*/




        }
    }
}
