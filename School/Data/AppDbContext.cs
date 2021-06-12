using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding
            //Students
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, FirstName = "Abdulmajeed", LastName = "Almaymuni", Email = "Abdulmajeed@gmail.com" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 2, FirstName = "Ahmed", LastName = "Almaymuni", Email = "Ahmed@gmail.com" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 3, FirstName = "Abdullah", LastName = "Almaymuni", Email = "Abdullah@gmail.com" });

            //Teachers
            modelBuilder.Entity<Teacher>().HasData(new Teacher { Id = 1, FullName = "Abdullah Altuwaim", Email = "AAltuwaim@gmail.com", });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { Id = 2, FullName = "Hatem Alsalman", Email = "HAlsalman@gmail.com" });

            //Subjects
            modelBuilder.Entity<Subject>().HasData(new Subject { Id = 1, Title = "Math", TeacherId = 1 });
            modelBuilder.Entity<Subject>().HasData(new Subject { Id = 2, Title = "Physics", TeacherId = 1 });
            modelBuilder.Entity<Subject>().HasData(new Subject { Id = 3, Title = "Computer", TeacherId = 2 });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }


    }
}
