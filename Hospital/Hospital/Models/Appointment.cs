using System;
using System.Collections.Generic;

#nullable disable

namespace Hospital.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string Speciality { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
    }
}
