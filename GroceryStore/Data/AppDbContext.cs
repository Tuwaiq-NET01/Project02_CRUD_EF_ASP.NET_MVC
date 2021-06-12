using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GroceryStore.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }



        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BranchProduct> BranchProduct { get; set; }
        public DbSet<CustomerProduct> CustomerProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchProduct>().HasKey(br => new { br.BranchId, br.ProductId });
            modelBuilder.Entity<CustomerProduct>().HasKey(cp => new { cp.CustomerId, cp.ProductId });

            //insert branches
            modelBuilder.Entity<Branch>().HasData(new Branch
            { BranchId = 1, Name = "Norah Grocery", Address = "Riyadh" });
            modelBuilder.Entity<Branch>().HasData(new Branch
            { BranchId = 2, Name = "Norah Grocery", Address = "Dammam" });
            modelBuilder.Entity<Branch>().HasData(new Branch
            { BranchId = 3, Name = "Norah Grocery", Address = "Jeddah" });

            //insert customers
            modelBuilder.Entity<Customer>().HasData(new Customer
            { CustomerId = 1, FirstName = "Norah", LastName = "Almutairi", Email = "norah@outlook.sa", Phone = "0534355512", Address = "Jeddah, Al Marwah, Saeed Albasri street" });
            modelBuilder.Entity<Customer>().HasData(new Customer
            { CustomerId = 2, FirstName = "Maha", LastName = "Alzahrani", Email = "Maha@outlook.sa", Phone = "0565355519", Address = "Riyadh, Al Narjis, Alsalamah street" });
            modelBuilder.Entity<Customer>().HasData(new Customer
            { CustomerId = 3, FirstName = "Mona", LastName = "Alghamdi", Email = "Mona@outlook.sa", Phone = "0535366514", Address = "Dammam, Al Rawdah, Malik Ibn Jubair street" });



            //insert User
            modelBuilder.Entity<User>().HasData(new User
            { Id = 1, UserName = "Norah123", Password = "sfs34", CustomerId = 1 });
            modelBuilder.Entity<User>().HasData(new User
            { Id = 2, UserName = "Mahaaz", Password = "maha222", CustomerId = 2 });
            modelBuilder.Entity<User>().HasData(new User
            { Id = 3, UserName = "Moon", Password = "Moon66", CustomerId = 3 });

            //insert BranchProduct
            modelBuilder.Entity<BranchProduct>().HasData(new BranchProduct
            { BranchId = 1, ProductId = 1 });
            modelBuilder.Entity<BranchProduct>().HasData(new BranchProduct
            { BranchId = 2, ProductId = 1 });
            modelBuilder.Entity<BranchProduct>().HasData(new BranchProduct
            { BranchId = 3, ProductId = 2 });
            modelBuilder.Entity<BranchProduct>().HasData(new BranchProduct
            { BranchId = 2, ProductId = 2 });
            modelBuilder.Entity<BranchProduct>().HasData(new BranchProduct
            { BranchId = 2, ProductId = 3 });
            modelBuilder.Entity<BranchProduct>().HasData(new BranchProduct
            { BranchId = 1, ProductId = 2 });

            //insert CustomerProduct
            modelBuilder.Entity<CustomerProduct>().HasData(new CustomerProduct
            { CustomerId = 1, ProductId = 2 });
            modelBuilder.Entity<CustomerProduct>().HasData(new CustomerProduct
            { CustomerId = 2, ProductId = 1 });
            modelBuilder.Entity<CustomerProduct>().HasData(new CustomerProduct
            { CustomerId = 2, ProductId = 2 });
            modelBuilder.Entity<CustomerProduct>().HasData(new CustomerProduct
            { CustomerId = 3, ProductId = 1 });
            modelBuilder.Entity<CustomerProduct>().HasData(new CustomerProduct
            { CustomerId = 3, ProductId = 2 });
            modelBuilder.Entity<CustomerProduct>().HasData(new CustomerProduct
            { CustomerId = 3, ProductId = 3 });


            //insert Products
            modelBuilder.Entity<Product>().HasData(new Product
            { ProductId = 1, Name = "Apple", Price = 1.5f, Image = "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/170x165/9df78eab33525d08d6e5fb8d27136e95/1/3/132.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product
            { ProductId = 2, Name = "Orange", Price = 1.5f, Image = "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/340x330/9df78eab33525d08d6e5fb8d27136e95/o/r/orange-2.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product
            { ProductId = 3, Name = "Banana", Price = 3.5f, Image = "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/340x330/9df78eab33525d08d6e5fb8d27136e95/5/0/500_0.jpg" });


        }
    }
}

    

