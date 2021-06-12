using Microsoft.EntityFrameworkCore;
using SupplierProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Data
{
    public class AppDbContext : DbContext
    {
       
        public DbSet<SupplierModel> Suppliers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupplierModel>().HasData(new SupplierModel { SupplierID = 1, FirstName = "Yasmin", LastName = "AlGhamdi", Gender = "Female", Address = "Jubail", PhoneNumber = "055-569-9110"});
            modelBuilder.Entity<SupplierModel>().HasData(new SupplierModel { SupplierID = 2, FirstName = "Rita", LastName = "Farr", Gender = "Female ", Address = "Dammam", PhoneNumber = "050-569-9110"});
            modelBuilder.Entity<SupplierModel>().HasData(new SupplierModel { SupplierID = 3, FirstName = "Tony", LastName = "Roberts", Gender = "Male", Address = "Riyadh", PhoneNumber = "054-932-6548"});
            modelBuilder.Entity<SupplierModel>().HasData(new SupplierModel { SupplierID = 4, FirstName = "Amelia", LastName = "Owen", Gender = "Female", Address = "Jeddah", PhoneNumber = "051-436-5094"});
            modelBuilder.Entity<SupplierModel>().HasData(new SupplierModel { SupplierID = 5, FirstName = "Kyle", LastName = "Fox", Gender = "Male ", Address = "Dammam", PhoneNumber = "059-330-4393"});
        }

        }
    }
