using Project03_CRUD_With_ASP.NET_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Project03_CRUD_With_ASP.NET_MVC.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}