using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project3_Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace Project3_Hotel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //create hotel table
        public DbSet<Hotel> Hotel { get; set; }

        //create room table
        public DbSet<Room> Room { get; set; }

        //create customer table
        public DbSet<Customer> Customer { get; set; }

        //create reservation table
        public DbSet<Reservation> Reservation { get; set; }

        //create services table
        public DbSet<Service> Service { get; set; }

        //create billing table
        public DbSet<Billing> Billing { get; set; }

        //create many to many join table room_reservation
        /*public DbSet<Rooms_Reservation> Rooms_Reservations { get; set; }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Rooms_Reservation>().HasKey(rr => new { rr.RoomNumber, rr.ReservationNumber });
        }

        
    }
}
