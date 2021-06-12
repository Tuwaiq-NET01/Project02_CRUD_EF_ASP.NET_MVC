using AirportsSystemsCrud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportsSystemsCrud.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AirportModel> Airports { get; set; }
        public DbSet<PlaneModel> Planes { get; set; }
        public DbSet<TripModel> Trips { get; set; }
        public DbSet<PassengerModel> Passengers { get; set; }
        public DbSet<EmpolyeeModel> Empolyees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Airports Info
            modelBuilder.Entity<AirportModel>().HasData(new AirportModel
            {
                Airport_ID = 1,
                Airport_Short = "ANN",
                Airport_Name = "ALAIN INTERNATIONAL AIRPORT",
                Country_City = "emirates",
                Gate = "G11"
            });
            modelBuilder.Entity<AirportModel>().HasData(new AirportModel
            {
                Airport_ID = 2,
                Airport_Short = "AQJ",
                Airport_Name = "KING HUSSAIN INTERNATIONAL AIRPORT",
                Country_City = "JURDAN",
                Gate = "G107"
            });
            modelBuilder.Entity<AirportModel>().HasData(new AirportModel
            {
                Airport_ID = 3,
                Airport_Short = "AUH",
                Airport_Name = "ABUDAHABI INTERNATIONAL AIRPORT",
                Country_City = "emirates",
                Gate = "G07"
            });
            modelBuilder.Entity<AirportModel>().HasData(new AirportModel
            {
                Airport_ID = 4,
                Airport_Short = "BAH",
                Airport_Name = "BAHRAIN INTERNATIONAL AIRPORT",
                Country_City = "bahrain",
                Gate = "G34"
            });
            modelBuilder.Entity<AirportModel>().HasData(new AirportModel
            {
                Airport_ID = 5,
                Airport_Short = "DMM",
                Airport_Name = "KING FAHD INTERNATIONAL AIRPORT",
                Country_City = "dammam",
                Gate = "G2"
            });

            //Planes Info

            modelBuilder.Entity<PlaneModel>().HasData(new PlaneModel
            {
                Plane_ID = 11,
                Plane_Type = "Airbus",
                Plane_Name = "Airbus A300 / A310",
                Capacity = 500

            });
            modelBuilder.Entity<PlaneModel>().HasData(new PlaneModel
            {
                Plane_ID = 14,
                Plane_Type = "Airbus",
                Plane_Name = "Airbus 350",
                Capacity = 350

            });
            modelBuilder.Entity<PlaneModel>().HasData(new PlaneModel
            {
                Plane_ID = 15,
                Plane_Type = "Airbus",
                Plane_Name = "Airbus 380",
                Capacity = 250

            });
            modelBuilder.Entity<PlaneModel>().HasData(new PlaneModel
            {
                Plane_ID = 13,
                Plane_Type = "Airbus",
                Plane_Name = "Airbus 340",
                Capacity = 340

            }); modelBuilder.Entity<PlaneModel>().HasData(new PlaneModel
            {
                Plane_ID = 12,
                Plane_Type = "Airbus",
                Plane_Name = "Airbus 330",
                Capacity = 200

            });
            //passangers
            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel
            {
                Passenger_ID = 234567890,
                Passport_NO = 10,
                First_Name = "Sou",
                Last_Name = "Hong",
                Gender = "Male",
                Nationality = "Japanese",

            });
            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel
            {
                Passenger_ID = 987654321,
                Passport_NO = 12,
                First_Name = "Zaina",
                Last_Name = "Algmosh",
                Gender = "Female",
                Nationality = "Egyptian",

            });
            modelBuilder.Entity<PassengerModel>().HasData(new PassengerModel
            {
                Passenger_ID = 345678901,
                Passport_NO = 20,
                First_Name = "Mohammed",
                Last_Name = "Alqahtani",
                Gender = "Male",
                Nationality = "Saudi Arabia",

            });
            //<--------------------------------Trips---------------------------->
            //Trips
            modelBuilder.Entity<TripModel>().HasData(new TripModel
            {
                TripID = 61132,
                Take_Off_Time = 22,
                Trip_Type = "Internal",
                Road_Type = "one-way",
                Cabin_Class = "guest",
                Destination = "dammam",
                Price = 457,
                Weight = 30,
                Duration = 3,

            });
            modelBuilder.Entity<TripModel>().HasData(new TripModel
            {
                TripID = 61234,
                Take_Off_Time = 23,
                Trip_Type = "international",
                Road_Type = "one-way",
                Cabin_Class = "first",
                Destination = "LA-USA",
                Price = 7939,
                Weight = 50,
                Duration = 10,

            });
            modelBuilder.Entity<TripModel>().HasData(new TripModel
            {
                TripID = 61345,
                Take_Off_Time = 00,
                Trip_Type = "international",
                Road_Type = "round-trip",
                Cabin_Class = "guest",
                Destination = "Turkey",
                Price = 4211,
                Weight = 40,
                Duration = 13,

            });
            modelBuilder.Entity<TripModel>().HasData(new TripModel
            {
                TripID = 61456,
                Take_Off_Time = 19,
                Trip_Type = "international",
                Road_Type = "round-trip",
                Cabin_Class = "guest",
                Destination = "NewYork-USA",
                Price = 5689,
                Weight = 40,
                Duration = 14,

            });
            modelBuilder.Entity<TripModel>().HasData(new TripModel
            {
                TripID = 61567,
                Take_Off_Time = 02,
                Trip_Type = "international",
                Road_Type = "one-way",
                Cabin_Class = "guest",
                Destination = "Bali",
                Price = 2945,
                Weight = 40,
                Duration = 11,

            });
        }

    }
}
