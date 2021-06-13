using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Page> Pages { get; set; }
    public DbSet<Block> Blocks { get; set; }
    public DbSet<Category> Categories { get; set; }
    }
}