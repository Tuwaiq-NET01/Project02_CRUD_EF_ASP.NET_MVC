using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarStore.Models;
namespace CarStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ChassisModel> Chassis { get; set; }
        public DbSet<EngineModel> Engine { get; set; }
        public DbSet<GearModel> Gear { get; set; }
        public DbSet<ColorModel> Color { get; set; }
        public DbSet<CarOrderModel> CarOrderModel { get; set; }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // data seeding
            modelBuilder.Entity<ChassisModel>().HasData(
                new ChassisModel
                {
                    Id = 1,
                    Type = "Sedan",
                    Image = "https://previews.123rf.com/images/nerthuz/nerthuz1610/nerthuz161000173/65011853-unibody-car-chassis.jpg",
                    Price = 15000
                });
            modelBuilder.Entity<ChassisModel>().HasData(
                new ChassisModel
                {
                    Id = 2,
                    Type = "SUV",
                    Image = "https://preview.free3d.com/img/2016/04/2374224423268910544/6ud0kqh2-900.jpg",
                    Price = 20000
                });

            // data seeding
            modelBuilder.Entity<EngineModel>().HasData(
                new EngineModel
                {
                    Id = 1,
                    Type = "V-6",
                    Image = "https://carpart.com.au/uploads/images/blog/204/v6engine-1569930056.jpg",
                    Price = 15000
                });
            modelBuilder.Entity<EngineModel>().HasData(
                new EngineModel
                {
                    Id = 2,
                    Type = "V-8",
                    Image = "https://www.renderhub.com/markos3d/lsa-v8-engine-supercharged-muscle-car-engine/lsa-v8-engine-supercharged-muscle-car-engine-01.jpg",
                    Price = 30000
                });
            modelBuilder.Entity<EngineModel>().HasData(
                new EngineModel
                {
                    Id = 3,
                    Type = "V-12",
                    Image = "https://best-automechanicschools.com/wp-content/uploads/2018/11/turbocharger-vs-supercharger-v12-engine-18.png",
                    Price = 60000
          
                });

            // data seeding
            modelBuilder.Entity<GearModel>().HasData(
                new GearModel
                {
                    Id = 1,
                    Type = "Automatic",
                    Image = "https://st4.depositphotos.com/1000844/22907/i/1600/depositphotos_229077072-stock-photo-automatic-gear-box-stick.jpg",
                    Price = 20000
                });
            modelBuilder.Entity<GearModel>().HasData(
                new GearModel
                {
                    Id = 2,
                    Type = "Manual",
                    Image = "https://miro.medium.com/max/2000/1*drEf-yp7j3_x23nJSo---w.jpeg",
                    Price = 10000
                });

            // data seeding
            modelBuilder.Entity<ColorModel>().HasData(
                new ColorModel
                {
                    Id = 1,
                    Type = "White",
                    Image = "https://st4.depositphotos.com/26898060/37821/i/450/depositphotos_378210622-stock-photo-modern-luxury-white-car-front.jpg",
                    Price = 5000
                });
            modelBuilder.Entity<ColorModel>().HasData(
                new ColorModel
                {
                    Id = 2,
                    Type = "Black",
                    Image = "https://img.freepik.com/free-photo/front-view-generic-brandless-moder-car_110488-502.jpg",
                    Price = 5000
                });

            modelBuilder.Entity<CarOrderModel>().HasData(
                new CarOrderModel
                {
                    Id = 1,
                    ChassisId = 1,
                    EngineId = 1,
                    GearId = 1,
                    ColorId = 1,
                    TotalPrice = 55000
                });
        }
    }
}
