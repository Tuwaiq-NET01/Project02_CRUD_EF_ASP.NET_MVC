using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University_Project3_SSMS.Models;

namespace University_Project3_SSMS.Data
{
    public class AppDbContext : DbContext
    {

        // connection with database
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        // creat table

        public DbSet<StudentModel> Students { get; set; }
        public DbSet<CollegeModel> Colleges { get; set; }
        public DbSet<InstructorModel> Instructors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CollegeModel>().HasData(new CollegeModel { Id = 1, Name = "FCIT" }); 
            modelBuilder.Entity<CollegeModel>().HasData(new CollegeModel { Id = 2, Name = "College of Engineering" });


            modelBuilder.Entity<InstructorModel>().HasData(new InstructorModel { Id = 1, Name = "Hasan" , PhoneNum ="0567800800"});
            modelBuilder.Entity<InstructorModel>().HasData(new InstructorModel { Id = 2, Name = "Ahmed", PhoneNum = "0567800008" });



            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 1, Name = "Hussain Abdullah Alghamdi", PhoneNum = "0567800818", DateOfBirth = new DateTime(1991, 1, 11), Major = "IS", CollegeId = 1, InstructorId = 1 });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 2, Name = "Thamer Saleh AlMthni", PhoneNum = "0551609938", DateOfBirth = new DateTime(1995, 7, 11), Major = "CS", CollegeId = 1, InstructorId = 2 });

        }
    }
}
