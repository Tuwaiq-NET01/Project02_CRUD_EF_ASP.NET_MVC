using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hakam.Models;

namespace Hakam.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<QuoteModel> Quotes{ get; set; }
        public DbSet<SpeakerModel> Speakers{ get; set; }
        public DbSet<PodcastModel> Podcasts { get; set; }


    }
}