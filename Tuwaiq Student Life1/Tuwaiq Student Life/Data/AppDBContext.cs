using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tuwaiq_Student_Life.Models;

namespace Tuwaiq_Student_Life.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Room>()
                .Property(r => r.Email)
                .IsRequired();*/
            //seeding
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 1, FirstName = "Amal", LastName = "Fahad", Email = "Amal@Amal" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 2, FirstName = "Leenah", LastName = "Ahmad", Email = "Leenah@Leenah" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 3, FirstName = "Sarah", LastName = "Ali", Email = "Sarah@Sarah" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 4, FirstName = "Reem", LastName = "Khalid", Email = "Reem@Reem" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 5, FirstName = "Ali", LastName = "Saad", Email = "Ali@Ali" });

            modelBuilder.Entity<SubjectModel>().HasData(new SubjectModel { Id = 1, SubjectName = "MVC .Net" });
            modelBuilder.Entity<SubjectModel>().HasData(new SubjectModel { Id = 2, SubjectName = "Design Patterns" });
            modelBuilder.Entity<SubjectModel>().HasData(new SubjectModel { Id = 3, SubjectName = "Unit testing" });

            modelBuilder.Entity<InstructorModel>().HasData(new InstructorModel { Id = 1, FirstName = "Salem", LastName = "Ahamd", Email = "Salem@Salem", Bio = "", SubjectId = 1});
            modelBuilder.Entity<InstructorModel>().HasData(new InstructorModel { Id = 2, FirstName = "Hanaa", LastName = "Abdullah", Email = "Hanaa@Hanaa", Bio = "", SubjectId = 1 });
            modelBuilder.Entity<InstructorModel>().HasData(new InstructorModel { Id = 3, FirstName = "Waleed", LastName = "Rashed", Email = "Waleed@Waleed", Bio = "", SubjectId = 2 });
            modelBuilder.Entity<InstructorModel>().HasData(new InstructorModel { Id = 4, FirstName = "Rawan", LastName = "Yousef", Email = "Rawan@Rawan", Bio = "", SubjectId = 3 });

            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 1, InstructorId = 1, StudentId = 1 });
            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 2, InstructorId = 1, StudentId = 2 });
            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 3, InstructorId = 1, StudentId = 3 });
            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 4, InstructorId = 1, StudentId = 4 });
            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 5, InstructorId = 1, StudentId = 5 });

            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 6, InstructorId = 2, StudentId = 1 });
            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 7, InstructorId = 2, StudentId = 2 });
            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 8, InstructorId = 2, StudentId = 3 });

            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 9, InstructorId = 3, StudentId = 3 });
            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 10, InstructorId = 3, StudentId = 4 });
            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 11, InstructorId = 3, StudentId = 5 });

            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 12, InstructorId = 4, StudentId = 1 });
            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 13, InstructorId = 4, StudentId = 2 });
            modelBuilder.Entity<InstructorStudentModel>().HasData(new InstructorStudentModel { Id = 14, InstructorId = 4, StudentId = 3 });










        }

        public DbSet<InstructorModel> Instructors { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<SessionModel> Sessions { get; set; }
        public DbSet<SubjectModel> Subjects { get; set; }
        public DbSet<StudentSessionModel> StudentsSessions { get; set; }
        public DbSet<InstructorStudentModel> InstructorsStudents { get; set; }


    }
}
