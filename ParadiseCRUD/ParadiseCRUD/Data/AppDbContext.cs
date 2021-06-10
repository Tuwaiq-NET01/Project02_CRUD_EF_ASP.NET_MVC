using Microsoft.EntityFrameworkCore;
using ParadiseCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParadiseCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //seeding

            modelBuilder.Entity<Flower>()
                .HasData(new Flower
                {
                    ID = 1,
                    Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/pink-dahlias-royalty-free-image-513204805-1562778270.jpg?crop=0.445xw:1.00xh;0.450xw,0&resize=980:*",
                    Name = "Dahlias",
                    Tempreture = "20°–22°C",
                    LevelCare = "Easy",
                    Place = "indoors",
                    Size = "6 to 8 inches"
                });

            modelBuilder.Entity<Flower>()
         .HasData(new Flower
         {
             ID = 2,
             Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cornflowers-royalty-free-image-104696040-1562778695.jpg?crop=0.445xw:1.00xh;0.386xw,0&resize=980:*",
             Name = "Cornflower",
             Tempreture = "15°-26°C",
             LevelCare = "Easy",
             Place = "outdoors",
             Size = "6 to 9 inches"
         });

            modelBuilder.Entity<Plant>()
  .HasData(new Plant
  {
      ID = 1,
      Image = "https://images.unsplash.com/photo-1598880940080-ff9a29891b85?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=700&q=60",
      Name = "Pothos",
      Tempreture = "15°-29°C",
      LevelCare = "Easy",
      Place = "indoors",
      Size = "12 inches"
  });

        }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Comment> Comments { get; set; }
       

    }
}
