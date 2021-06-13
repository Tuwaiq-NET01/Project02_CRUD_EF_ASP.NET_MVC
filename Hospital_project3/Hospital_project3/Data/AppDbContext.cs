using Hospital_project3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_project3.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PhysicianModel> Physicians { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<AppointmentModel> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientModel>().HasKey(Primary => Primary.NationalID);

            // seed data for Physicians
            modelBuilder.Entity<PhysicianModel>().HasData(new PhysicianModel { Id = 1110, Name = "Hossam", Position = "Pediatrician", Gender = "Male" });
            modelBuilder.Entity<PhysicianModel>().HasData(new PhysicianModel { Id = 1111, Name = "Saad", Position = "Internist", Gender = "Male" });
            modelBuilder.Entity<PhysicianModel>().HasData(new PhysicianModel { Id = 1112, Name = "John", Position = "Peadiatric neurologist", Gender = "Male" });
            modelBuilder.Entity<PhysicianModel>().HasData(new PhysicianModel { Id = 1113, Name = "Eman", Position = "Cardiologist", Gender = "Female" });
            modelBuilder.Entity<PhysicianModel>().HasData(new PhysicianModel { Id = 1119, Name = "Sara", Position = "Psychiatrist", Gender = "Female" });
            modelBuilder.Entity<PhysicianModel>().HasData(new PhysicianModel { Id = 1117, Name = "Hana", Position = "Surgeon", Gender = "Female" });
            modelBuilder.Entity<PhysicianModel>().HasData(new PhysicianModel { Id = 1144, Name = "Jason", Position = "Dermatologist", Gender = "Male" });
            modelBuilder.Entity<PhysicianModel>().HasData(new PhysicianModel { Id = 1180, Name = "Abrar", Position = "Internist", Gender = "Female" });
            modelBuilder.Entity<PhysicianModel>().HasData(new PhysicianModel { Id = 1151, Name = "Derek", Position = "Surgeon", Gender = "Male" });

            // seed data for Departments
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { ID = 27, Name = "Cardiology", PhysicianId = 1113 });
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { ID = 66, Name = "Internal medicine", PhysicianId = 1111 });
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { ID = 90, Name = "Anesthetics", PhysicianId = 1151 });
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { ID = 44, Name = "Emergency", PhysicianId = 1113 });
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { ID = 20, Name = "Neonatal", PhysicianId = 1112 });

            // seed data for Patients
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { NationalID = 1122998, Name = "Sara", Address = "Almoroj", Gender = "Female" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { NationalID = 1124398, Name = "Lama", Address = "Almoroj", Gender = "Female" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { NationalID = 1683398, Name = "Saud", Address = "Olia", Gender = "Male" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { NationalID = 1992755, Name = "Fares", Address = "Alworod", Gender = "Male" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { NationalID = 1775342, Name = "Battal", Address = "Alqadsiah", Gender = "Male" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { NationalID = 1883547, Name = "Mohhamad", Address = "Narjes", Gender = "Male" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { NationalID = 1354922, Name = "Fai", Address = "Qurtubah", Gender = "Female" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { NationalID = 1820336, Name = "Salwa", Address = "Alsalman", Gender = "Female" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { NationalID = 1837354, Name = "Lamees", Address = "Alaziziah", Gender = "Female" });

            // seed data for Appointments
            modelBuilder.Entity<AppointmentModel>().HasData(new AppointmentModel { ID = 772, PatientId = 1124398, PhysicianId = 1110, Date_Time = "10-12-2021 09:30AM" });
            modelBuilder.Entity<AppointmentModel>().HasData(new AppointmentModel { ID = 733, PatientId = 1683398, PhysicianId = 1113, Date_Time = "03-09-2021 10:00AM" });
            modelBuilder.Entity<AppointmentModel>().HasData(new AppointmentModel { ID = 992, PatientId = 1837354, PhysicianId = 1119, Date_Time = "09-02-2021 08:00AM" });
            modelBuilder.Entity<AppointmentModel>().HasData(new AppointmentModel { ID = 338, PatientId = 1354922, PhysicianId = 1180, Date_Time = "11-07-2021 09:45AM" });
            modelBuilder.Entity<AppointmentModel>().HasData(new AppointmentModel { ID = 334, PatientId = 1820336, PhysicianId = 1151, Date_Time = "30-05-2021 10:35AM" });
            modelBuilder.Entity<AppointmentModel>().HasData(new AppointmentModel { ID = 177, PatientId = 1992755, PhysicianId = 1180, Date_Time = "20-11-2021 12:00PM" });
            modelBuilder.Entity<AppointmentModel>().HasData(new AppointmentModel { ID = 886, PatientId = 1775342, PhysicianId = 1111, Date_Time = "19-10-2021 01:00PM" });
        }
    }
}
