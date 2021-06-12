using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventsHall.Models;

namespace EventsHall.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HallModel>().HasData(new HallModel { Id = 1, Capacity = 50, Name = "First Venue", Avaliability = true });
            modelBuilder.Entity<HallModel>().HasData(new HallModel { Id = 2, Capacity = 200, Name = "Main Hall", Avaliability = false });
            modelBuilder.Entity<HallModel>().HasData(new HallModel { Id = 3, Capacity = 1000, Name = "Conference Hall ", Avaliability = true });

            modelBuilder.Entity<PresentorModel>().HasData(new PresentorModel { Id = 10, Name = "Sameera Alhussainy", Email = "spurofthemoment@gmail.com", Phone = 0556110112, Field = "IT" });
            modelBuilder.Entity<PresentorModel>().HasData(new PresentorModel { Id = 2, Name = "Elon Musk", Email = "ceo@tesla.com", Phone = 0556123123, Field = "Business" });
            modelBuilder.Entity<PresentorModel>().HasData(new PresentorModel { Id = 665, Name = "Michael Jackson", Email = "mj@gmail.com", Phone = 0522666987, Field = "Health" });
            modelBuilder.Entity<PresentorModel>().HasData(new PresentorModel { Id = 1, Name = "Steven Hawking", Email = "steven@galaxybrain.com", Phone = 0598644222, Field = "Science" });
            modelBuilder.Entity<PresentorModel>().HasData(new PresentorModel { Id = 100, Name = "Hala Alyousef", Email = "hala@galaxybrain.com", Phone = 0522441234, Field = "Bullshit" });
            modelBuilder.Entity<PresentorModel>().HasData(new PresentorModel { Id = 333, Name = "Reema Alyousef", Email = "reema@galaxybrain.com", Phone = 0547722199, Field = "Divine Philosophy" });

            modelBuilder.Entity<AttendeeModel>().HasData(new AttendeeModel { Id = 13, Name = "Reema Alyousef", Email = "reema@gmail.com", Phone = 0547722199, Field = "IT", EventId = 1000 });
            modelBuilder.Entity<AttendeeModel>().HasData(new AttendeeModel { Id = 7, Name = "Hala Alyousef", Email = "hala@gmail.com", Phone = 0554124771, Field = "Business", EventId = 111111 });
            modelBuilder.Entity<AttendeeModel>().HasData(new AttendeeModel { Id = 4, Name = "Dorrah Alsaad", Email = "durrdurr@gmail.com", Phone = 0532121731, Field = "Marketing", EventId = 111111 });

            modelBuilder.Entity<EventModel>().HasData(new EventModel
            {
                Id = 1000,
                Name = "What happens when the robots take our jobs?",
                Time = "Friday, June 4, 2021 8:30:00 PM",
                Duration = "2 Hours",
                PresentorName = "Sameera Alhussainy",


                Image = "https://pi.tedcdn.com/r/talkstar-assets.s3.amazonaws.com/production/playlists/playlist_642/2437dd5f-4efd-40e9-a417-8c9d879ac9ea/What-happens-after-robots-take-our-jobs_1200x627+(1).jpg?quality=89&w=1200",
                HallId = 3,
                Description = "To lose our jobs to our future supreme AI overlords ... or to not? That's the question (and we have some surprising answers).",
               
            });
            modelBuilder.Entity<EventModel>().HasData(new EventModel
            {
                Id = 9999,
                Name = "The Next Outbreak? We're Not Ready",
                Time = "Friday, August 1, 2021 7:30:00 PM",
                Duration = "3 Hours",
                PresentorName = "Michael Jackson",
                Image = "https://www.gard.no/Content/29112072/cache=20203101143212/Coronavirus_people.jpg",
                HallId = 2,
                Description = "In 2014, the world avoided a global outbreak of Ebola, thanks to thousands of selfless health workers -- plus, frankly, some very good luck. In hindsight, we know what we should have done better. So, now's the time, MJ suggests, to put all our good ideas into practice, from scenario planning to vaccine research to health worker training. As he says, There's no need to panic ... but we need to get going.",
                
            });

            modelBuilder.Entity<EventModel>().HasData(new EventModel
            {
                Id = 111111,
                Name = "Inside the Mind of a Master Procrastinator",
                Time = "Friday, August 16, 2021 6:30:00 PM",
                Duration = "3 Hours",
                PresentorName = "Reema Alyousef",
                Image = "https://cdn.substack.com/image/fetch/f_auto,q_auto:good,fl_progressive:steep/https%3A%2F%2Fbucketeer-e05bbc84-baa3-437e-9518-adb32be77984.s3.amazonaws.com%2Fpublic%2Fimages%2F3586ad3c-6847-457a-ba75-b3f5d4e6d46a_1920x1080.png",
                HallId = 1,
                Description = "Reema Alyousef knows that procrastination doesn't make sense, but she's never been able to shake her habit of waiting until the last minute to get things done. In this hilarious and insightful talk, Reema takes us on a journey through YouTube binges, Gaming rabbit holes and bouts of staring out the window -- and encourages us to think harder about what we're really procrastinating on, before we run out of time.",
                
            });

            modelBuilder.Entity<EventModel>().HasData(new EventModel
            {
                Id = 19099,
                Name = "The Power of Introverts",
                Time = "Monday, July 22, 2021 9:00:00 PM",
                Duration = "2 Hours"
                ,
                PresentorName = "Steven Hawking",
                Image = "https://i.insider.com/53eccec469beddaa722af1d8?width=1000&format=jpeg&auto=webp",
                HallId = 2,
                Description = "In a culture where being social and outgoing are prized above all else, it can be difficult, even shameful, to be an introvert. But, as Susan Cain argues in this passionate talk, introverts bring extraordinary talents and abilities to the world, and should be encouraged and celebrated.",
               
            });

  
        }

        public DbSet<EventModel> Events { get; set; }
        public DbSet<PresentorModel> Presentors { get; set; }

        public DbSet<AttendeeModel> Attendees { get; set; }

        public DbSet<HallModel> Halls { get; set; }
    }
}