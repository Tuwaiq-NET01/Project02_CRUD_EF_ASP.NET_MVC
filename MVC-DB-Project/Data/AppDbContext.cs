using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_DB_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_DB_Project.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<PlayerModel> Players { get; set; }
        public DbSet<TeamModel> Teams { get; set; }
        public DbSet<CoacheModel> Coaches { get; set; }
        public DbSet<LeagueModel> leagues { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<PlayerModel>().HasData(new PlayerModel { Id = 1, number = 10, name = "Meshal", CoacheId = 1,LeagueId=1,TeamId=1 });
            modelBuilder.Entity<PlayerModel>().HasData(new PlayerModel { Id = 2, number = 7, name = "Meshal2", CoacheId = 2,LeagueId=2,TeamId=2 });
            modelBuilder.Entity<PlayerModel>().HasData(new PlayerModel { Id = 3, number = 15, name = "Meshal3", CoacheId = 3,LeagueId=3,TeamId=3 });
            modelBuilder.Entity<CoacheModel>().HasData(new CoacheModel { Id = 1, experience = 15, name = "Coache Meshal1", nationality = "KSA",LeagueId=1,TeamId=1 });
            modelBuilder.Entity<CoacheModel>().HasData(new CoacheModel { Id = 2, experience = 4, name = "Coache Meshal2", nationality = "ARG",LeagueId=2,TeamId=2 });
            modelBuilder.Entity<CoacheModel>().HasData(new CoacheModel { Id = 3, experience = 10, name = "Coache Meshal3", nationality = "USA",LeagueId=3,TeamId=3 });
            modelBuilder.Entity<TeamModel>().HasData(new TeamModel { Id = 1, numberOfPlayers = 28, name = "Team Meshal1", city = "Jeddah",LeagueId=1 });
            modelBuilder.Entity<TeamModel>().HasData(new TeamModel { Id = 2, numberOfPlayers = 30, name = "Team Meshal2", city = "Paris",LeagueId=2 });
            modelBuilder.Entity<TeamModel>().HasData(new TeamModel { Id = 3, numberOfPlayers = 25, name = "Team Meshal3", city = "Madrid",LeagueId=3 });
            modelBuilder.Entity<LeagueModel>().HasData(new LeagueModel { Id = 1, numberOfTeams = 16, name = "League Meshal1", country = "Saudi Arabia" });
            modelBuilder.Entity<LeagueModel>().HasData(new LeagueModel { Id = 2, numberOfTeams = 30, name = "League Meshal2", country = "France" });
            modelBuilder.Entity<LeagueModel>().HasData(new LeagueModel { Id = 3, numberOfTeams = 38, name = "League Meshal3", country = "Spain" });
            
        }*/
    }
}
