
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLearn.Models;
using Microsoft.EntityFrameworkCore;

namespace eLearn.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


                           modelBuilder.Entity<User_Lecturer>()
                          .HasKey(cc => new { cc.UserId, cc.LecturerId
                  });
                         modelBuilder.Entity<User_Lecturer>()
                             .HasOne(cc => cc.User)
                             .WithMany(b => b.User_Lecturer)
                             .HasForeignKey(cc => cc.UserId);
                         modelBuilder.Entity<User_Lecturer>()
                                      .HasOne(cc => cc.Lecturer)
                                      .WithMany(c => c.User_Lecturer)
                                      .HasForeignKey(cc => cc.LecturerId);
             

                         modelBuilder.Entity<Lecturer_Course>()
                              .HasKey(cc => new { cc.LecturerId, cc.CourseId
                 });
                          modelBuilder.Entity<Lecturer_Course>()
                              .HasOne(cc => cc.Lecturer)
                              .WithMany(b => b.Lecturer_Course)
                              .HasForeignKey(cc => cc.LecturerId);
                 modelBuilder.Entity<Lecturer_Course>()
                              .HasOne(cc => cc.Course)
                              .WithMany(c => c.Lecturer_Course)
                              .HasForeignKey(cc => cc.CourseId);


                         modelBuilder.Entity<User_Course>()
                  .HasKey(cc => new {
                      cc.UserId,
                      cc.CourseId
                  });

                         modelBuilder.Entity<User_Course>()
                             .HasOne(cc => cc.User)
                             .WithMany(b => b.User_Course)
                             .HasForeignKey(cc => cc.UserId);
                         modelBuilder.Entity<User_Course>()
                            .HasOne(cc => cc.Course)
                            .WithMany(c => c.User_Course)
                            .HasForeignKey(cc => cc.CourseId);
            



            //seedding
            
                         modelBuilder.Entity<User_Lecturer>().HasData(new User_Lecturer() { Id = 1, UserId = 1, LecturerId = 1 });
                         modelBuilder.Entity<User_Lecturer>().HasData(new User_Lecturer() { Id = 2, UserId = 1, LecturerId = 3 });
                         modelBuilder.Entity<User_Lecturer>().HasData(new User_Lecturer() { Id = 3, UserId = 2, LecturerId = 5 });
                         modelBuilder.Entity<User_Lecturer>().HasData(new User_Lecturer() { Id = 4, UserId = 2, LecturerId = 4 });
                         modelBuilder.Entity<User_Lecturer>().HasData(new User_Lecturer() { Id = 5, UserId = 3, LecturerId = 4 });
                         modelBuilder.Entity<User_Lecturer>().HasData(new User_Lecturer() { Id = 6, UserId = 3, LecturerId = 6 });
                         modelBuilder.Entity<User_Lecturer>().HasData(new User_Lecturer() { Id = 7, UserId = 4, LecturerId = 5 });
                         modelBuilder.Entity<User_Lecturer>().HasData(new User_Lecturer() { Id = 8, UserId = 4, LecturerId = 2 });

                         modelBuilder.Entity<User_Course>().HasData(new User_Course() { Id = 1, UserId = 1, CourseId = 1 });
                         modelBuilder.Entity<User_Course>().HasData(new User_Course() { Id = 2, UserId = 1, CourseId = 2 });
                         modelBuilder.Entity<User_Course>().HasData(new User_Course() { Id = 3, UserId = 2, CourseId = 4 });
                         modelBuilder.Entity<User_Course>().HasData(new User_Course() { Id = 4, UserId = 2, CourseId = 3 });
                         modelBuilder.Entity<User_Course>().HasData(new User_Course() { Id = 5, UserId = 3, CourseId = 5 });
                         modelBuilder.Entity<User_Course>().HasData(new User_Course() { Id = 6, UserId = 3, CourseId = 7 });
                         modelBuilder.Entity<User_Course>().HasData(new User_Course() { Id = 7, UserId = 4, CourseId = 8 });
                         modelBuilder.Entity<User_Course>().HasData(new User_Course() { Id = 8, UserId = 4, CourseId = 6 });


                         modelBuilder.Entity<Lecturer_Course>().HasData(new Lecturer_Course() { Id = 1 , LecturerId = 1, CourseId = 1 });
                         modelBuilder.Entity<Lecturer_Course>().HasData(new Lecturer_Course() { Id = 2 , LecturerId = 2, CourseId = 6 });
                         modelBuilder.Entity<Lecturer_Course>().HasData(new Lecturer_Course() { Id = 3 , LecturerId =3, CourseId = 2 });
                         modelBuilder.Entity<Lecturer_Course>().HasData(new Lecturer_Course() { Id = 4 , LecturerId = 4, CourseId = 4 });
                         modelBuilder.Entity<Lecturer_Course>().HasData(new Lecturer_Course() { Id = 5 , LecturerId = 4, CourseId = 5 });
                         modelBuilder.Entity<Lecturer_Course>().HasData(new Lecturer_Course() { Id = 6 , LecturerId = 4, CourseId = 3 });
                         modelBuilder.Entity<Lecturer_Course>().HasData(new Lecturer_Course() { Id = 7 , LecturerId = 5, CourseId = 4 });
                         modelBuilder.Entity<Lecturer_Course>().HasData(new Lecturer_Course() { Id = 8 , LecturerId = 5, CourseId = 8 });
                         modelBuilder.Entity<Lecturer_Course>().HasData(new Lecturer_Course() { Id = 9 , LecturerId = 6, CourseId = 7 });


                        modelBuilder.Entity<User>().HasData(new User { Id = 1, FirstName = "Amal", LastName = "Almutairi", Email = "Amal@gmail.com" });
                        modelBuilder.Entity<User>().HasData(new User { Id = 2, FirstName = "Lama", LastName = "Alsalman", Email = "Lama@gmail.com" });
                        modelBuilder.Entity<User>().HasData(new User { Id = 3, FirstName = "Reema", LastName = "Altwaim", Email = "Reema@gmail.com" });
                        modelBuilder.Entity<User>().HasData(new User { Id = 4, FirstName = "Sultan", LastName = "Alsalman", Email = "Sultan@gmail.com" });



                         modelBuilder.Entity<Lecturer>().HasData(new Lecturer { Id = 1, FirstName = "Bader", LastName = "alqahtani", Email = "Amal@gmail.com" });
                         modelBuilder.Entity<Lecturer>().HasData(new Lecturer { Id = 2, FirstName = "Sami", LastName = "Alshammari", Email = "Sami@gmail.com" });
                         modelBuilder.Entity<Lecturer>().HasData(new Lecturer { Id = 3, FirstName = "Ahad", LastName = "Alghamdi", Email = "Ahad@gmail.com" });
                         modelBuilder.Entity<Lecturer>().HasData(new Lecturer { Id = 4, FirstName = "Rami", LastName = "Alshehri ", Email = "Amal@gmail.com" });
                         modelBuilder.Entity<Lecturer>().HasData(new Lecturer { Id = 5, FirstName = "Fahad", LastName = "Alshammari", Email = "Sami@gmail.com" });
                         modelBuilder.Entity<Lecturer>().HasData(new Lecturer { Id = 6, FirstName = "Nora", LastName = "Alghamdi", Email = "Ahad@gmail.com" });


                         modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Science", CategoryDescription = "Know more about  science", CategoryImage = "https://image.shutterstock.com/z/stock-vector-science-word-cloud-53764600.jpg" });
                         modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Computer", CategoryDescription = "Know more about computer", CategoryImage = "https://d2gg9evh47fn9z.cloudfront.net/800px_COLOURBOX37705714.jpg" });


                        modelBuilder.Entity<Course>().HasData(new Course { Id = 1, CourseName = "Electrical Engineering", CourseDescription = "Unit: Introduction to electrical engineering", CourseImage = "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg", CourseLevel = "Beginner", CategoryId = 1 });
                        modelBuilder.Entity<Course>().HasData(new Course { Id = 2, CourseName = "Biology", CourseDescription = "Unit: Scale of the universe", CourseImage = "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg", CourseLevel = "Beginner", CategoryId = 1 });
                        modelBuilder.Entity<Course>().HasData(new Course { Id = 3, CourseName = "Cosmology ", CourseDescription = "Unit: Scale of the universe", CourseImage = "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg", CourseLevel = "Intermediate", CategoryId = 1 });
                        modelBuilder.Entity<Course>().HasData(new Course { Id = 4, CourseName = "Chemistry", CourseDescription = "Unit: IAtoms, compounds, and ions", CourseImage = "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg", CourseLevel = "Advanced", CategoryId = 1 });

                                                             modelBuilder.Entity<Course>().HasData(new Course { Id = 5, CourseName = "HTML/CSS: Making webpages", CourseDescription = "Unit: Intro to HTML/CSS: Making webpages", CourseImage = "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg", CourseLevel = "Beginner", CategoryId = 2 });
                                                             modelBuilder.Entity<Course>().HasData(new Course { Id = 6, CourseName = "Querying and managing data", CourseDescription = "Unit: Intro to SQL: Querying and managing data", CourseImage = "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg", CourseLevel = "Beginner", CategoryId = 2 });
                                                             modelBuilder.Entity<Course>().HasData(new Course { Id = 7, CourseName = "HTML/JS webpages interactive", CourseDescription = "Unit: HTML/JS: Making webpages interactive", CourseImage = "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg", CourseLevel = "Intermediate", CategoryId = 2 });
                                                             modelBuilder.Entity<Course>().HasData(new Course { Id = 8, CourseName = "JS: Natural Simulations", CourseDescription = "Unit: Advanced JS: Natural Simulations", CourseImage = "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg", CourseLevel = "Advanced", CategoryId = 2 });
            

        }

        public DbSet<User> User { get; set; }
        public DbSet<Lecturer> Lecturer { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User_Lecturer> User_Lecturer { get; set; }
        public DbSet<User_Course> User_Course { get; set; }
        public DbSet<Lecturer_Course> Lecturer_Course { get; set; }
    }
}
