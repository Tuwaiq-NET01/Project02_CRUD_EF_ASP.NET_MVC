using System;
using Microsoft.EntityFrameworkCore;
using Project03_CRUD.Models;

namespace Project03_CRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<InstructorModel> Instructors { get; set; }
        public DbSet<CourseModel> Courses { get; set; }

    }
}
