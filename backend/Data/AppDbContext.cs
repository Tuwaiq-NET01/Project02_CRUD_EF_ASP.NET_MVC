using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokeWars.Models;

namespace backend.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PokeWars.Models.User> User { get; set; }
        public DbSet<PokeWars.Models.Rank> Rank { get; set; }
        public DbSet<PokeWars.Models.Arena> Arena { get; set; }
        public DbSet<PokeWars.Models.Pokemon> Pokemon { get; set; }

    }
}
