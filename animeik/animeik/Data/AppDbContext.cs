using System.Collections.Generic;
using animeik.Models;
using Microsoft.EntityFrameworkCore;

namespace animeik.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Anime> Animes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Faviorts> Faviortes { get; set; }

        private Anime naruto = new Anime()
        {
            id = 1, title = "naruto", url = "www.examle.com", image_url = "e", type = "", episodes = 23,
            start_date = "2020", end_date = "2021", score = 6.5, Categoryid = 1
        };
        
        private Anime onepiece = new Anime()
        {
            id = 2, title = "onepiece", url = "www.examle.com", image_url = "s", type = "", episodes = 34,
            start_date = "2002", end_date = "2021", score = 9.5,Categoryid = 2
        };
        
        private Anime attack = new Anime()
        {
            id = 3, title = "attack on titan", url = "www.examle.com", image_url = "a", type = "", episodes = 12,
            start_date = "2004", end_date = "2021", score = 10.5,Categoryid = 1
        };
        
        private User hassan = new User() {id = 1, username = "hassan"};
        private User eren = new User() {id = 2, username = "eren"};

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category
                {Categoryid = 1, Name = "action"});
            modelBuilder.Entity<Category>().HasData(new Category
                {Categoryid = 2, Name= "romance"});
            
            modelBuilder.Entity<Anime>().HasData(onepiece);
            modelBuilder.Entity<Anime>().HasData(naruto);
            modelBuilder.Entity<Anime>().HasData(attack);
            modelBuilder.Entity<User>().HasData(eren);
            modelBuilder.Entity<User>().HasData(hassan);
            
            modelBuilder.Entity<Faviorts>().HasData(new Faviorts()
                {id = 1, AnimeIdid = 1,UserIdid = 1 });
            modelBuilder.Entity<Faviorts>().HasData(new Faviorts()
                {id = 2, AnimeIdid = 1,UserIdid = 2});
        }
    }
}