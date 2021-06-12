using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }
        //create tables
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ArticleModel> Articles { get; set; }
        public DbSet<CommentModel> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding initial data
           //modelBuilder.Entity<UserModel>().HasData(new UserModel { Id = 1, Username = "hananx", Email = "han@gg.com", Password = "gg123", Picture = "http://cdn.onlinewebfonts.com/svg/img_210318.png" });
           //modelBuilder.Entity<ArticleModel>().HasData(new ArticleModel { Id = 1, Title = "The Hinterkaifeck Murders", HTMLContent = "" });

        }
    }
}
