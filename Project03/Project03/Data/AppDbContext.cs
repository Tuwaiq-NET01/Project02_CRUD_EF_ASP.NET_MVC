using Microsoft.EntityFrameworkCore;
using Project03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project03.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //create movies table
        public DbSet<Movie> Ms { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
