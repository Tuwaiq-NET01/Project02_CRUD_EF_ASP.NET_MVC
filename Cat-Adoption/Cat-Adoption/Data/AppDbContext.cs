using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cat_Adoption.Data;
using Cat_Adoption.Models;

namespace Cat_Adoption.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding (run this only once put it as comment after you update database with it)
            modelBuilder.Entity<LocationModel>().HasData(new LocationModel { id = 1, name = "Vetsreet", phone = "303849244", address = "505 broadway st" });
            modelBuilder.Entity<LocationModel>().HasData(new LocationModel { id = 2, name = "Pawpatrol", phone = "758348939", address = "404 broadway st" });
            modelBuilder.Entity<LocationModel>().HasData(new LocationModel { id = 3, name = "smartPet", phone = " 7548484844 ", address = "303 broadway st" });
            modelBuilder.Entity<LocationModel>().HasData(new LocationModel { id = 4, name = "walmart", phone = " 657474384 ", address = "202 broadway st" });
            modelBuilder.Entity<LocationModel>().HasData(new LocationModel { id = 5, name = "Pet", phone = " 7548484844 ", address = "102 broadway st" });
            modelBuilder.Entity<LocationModel>().HasData(new LocationModel { id = 6, name = "kittycat", phone = " 8545499504 ", address = "30 broadway st" });
            modelBuilder.Entity<LocationModel>().HasData(new LocationModel { id = 7, name = "kittycat2", phone = " 85454995042 ", address = "30 broadway st2" });
            //seeding (run this only once put it as comment after you update database with it)
            modelBuilder.Entity<CatModel>().HasData(new CatModel { id = 1, OwnerId = 1,AdopterId=1, name = "Kat", age = "young", description = "Hi! My name is Kat and I’m an extremely friendly curious and social 1 year old. ( Shy at first of course...;)...)....I’m told I have exotic unique markings with silky coat you can’t even dream of ...;) My ideal home has very affectionate humans who don’t mind my daily exploring. I’m super flirty and love cuddling in with my foster mom in her bed and my siblings as well. If you’re looking for a cat with a dog personality then I will be your gal. ♥️", gender = "female", breed = "Domestic Shorthair", image = "https://pet-uploads.adoptapet.com/6/2/9/547432893.jpg", vaccination = true, LocationId = 1 });
            modelBuilder.Entity<CatModel>().HasData(new CatModel { id = 2, OwnerId = 1, AdopterId = 1, name = "Antoine and Beauregaurd", age = "young", description = " They are named Beauregaurd and Antoine. They are the smartest cats I have ever interacted with and and know words and love one another deeply. They are loving yet independent and will play for hours on end with either myself or another. I have an enclosed outdoor space they love to hang out in.", gender = "male", breed = " Bengal", image = "https://pet-uploads.adoptapet.com/8/b/9/546264169.jpg", vaccination = true, LocationId = 2 });
            modelBuilder.Entity<CatModel>().HasData(new CatModel { id = 3, OwnerId = 1, AdopterId = 1, name = "Elizabeth Taylor", age = "young", description = "Meet the ever-glamorous Elizabeth Taylor.she's 10 months old, like most celebrities, she’s reclusive and prefers a quiet environment. Elizabeth is also very shy and will require someone with patience. However, she is not shy when it’s time for cat treats! Elizabeth is a strict pescatarian, enjoying the finest fish and seafood. She also enjoys living her best life playing with her favorite toy balls. This exquisite girl has the most beautiful markings with a black whip-like tail and bangs. She is a glamorous girl and is looking for her up upscale forever home.", gender = "female", breed = "Domestic Shorthair", image = "https://pet-uploads.adoptapet.com/8/8/f/442558865.jpg", vaccination = true, LocationId = 3 });
            modelBuilder.Entity<CatModel>().HasData(new CatModel { id = 4, OwnerId = 2, AdopterId = 1, name = "Nyx", age = "Adult", description = "Nyx is a 3 years black domestic short hair cat. She is a very loving cat when she gets comfortable around you. Nyx loves playing with stuffed mice, but mainly loves lounging around the house. She is always by the door when I come home and will come say goodbye when I have to leave. She will be a bit shy at first until she gets comfortable with her surroundings. She originally was rescued from a very sad situation where she was not taken care of properly. She will require a home that is quiet and low key, and a person that will be patient with her and allow her to get used to new surroundings. Nyx has so much love to give- will you give her that chance?", gender = "female", breed = "Domestic Shorthair", image = "https://pet-uploads.adoptapet.com/2/9/5/516563701.jpg", vaccination = true, LocationId = 4 });
            modelBuilder.Entity<CatModel>().HasData(new CatModel { id = 5, OwnerId = 2, AdopterId = 1, name = "Pepper", age = "young", description = "Hello there! I’m Pepper, nice to meet ya!I'm 10 months old I’m a wee sweet sleepy boy looking for my tender and loving FUREVER home! One of my nicknames is Dr. Pepper! I have a doctorate in adorable from Major Cuties University. Not to brag but I graduated at the top of my class! The black smudge on my nose and spotted coat are how I got my name. My smudge and my cute little overbite are my most precious features; but I have too many to count them all. I’m quite a handsome kitten! I’m really excited to live with other kitties and maybe even a doggy! My foster home is full of furbabies- cats of all ages and even a dog! I’m well adjusted, and brave around new people!", gender = "male", breed = "Domestic Shorthair", image = "https://pet-uploads.adoptapet.com/e/5/a/536736979.jpg", vaccination = true, LocationId = 5 });
            modelBuilder.Entity<CatModel>().HasData(new CatModel { id = 6, OwnerId = 2, AdopterId = 1, name = "Mae", age = "Adult", description = "Gracie Mae is a 5 years sweet and confident girl--very adventurous and brave! She's bonded to her sister, Hope, and the two ladies will be 4 years old in May 2020. Gracie Mae loves to explore and play. She also loves to cuddle A LOT. She is a talkative young lady and really enjoys affection. She may be shy with new people, but once she settles in, she's a lovebug.", gender = "female", breed = "Domestic Shorthair", image = "https://pet-uploads.adoptapet.com/7/9/6/477702221.jpg", vaccination = true, LocationId = 6 });

            modelBuilder.Entity<OwnerModel>().HasData(new OwnerModel { id = 1, name = "Rose", phone = " 85454995042 ", age = 24, gender = "female", email = "roro@gmail.com", reason = "relocating", image = "https://images.unsplash.com/photo-1508002366005-75a695ee2d17?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80" });
            modelBuilder.Entity<OwnerModel>().HasData(new OwnerModel { id = 2, name = "Jack", phone = " 46736437743 ", age = 54, gender = "male", email = "jojo@gmail.com", reason = "relocating", image = "https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80" });


            modelBuilder.Entity<AdopterModel>().HasData(new AdopterModel { id = 1, name = "Ken", phone = " 85454995042 ", age = 42, gender = "male", email = "koko@gmail.com", image = "https://images.unsplash.com/photo-1521119989659-a83eee488004?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=728&q=80" });
            modelBuilder.Entity<AdopterModel>().HasData(new AdopterModel { id = 2, name = "Natasha", phone = " 46736437743 ", age = 30, gender = "female", email = "momo@gmail.com", image = "https://images.unsplash.com/photo-1514448553123-ddc6ee76fd52?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=668&q=80" });

        }

        // create sql table 
        public DbSet<CatModel> cat { get; set; }
        public DbSet<AdopterModel> adopter { get; set; }
        public DbSet<OwnerModel> owner { get; set; }
        public DbSet<LocationModel> location { get; set; }
    }

}
