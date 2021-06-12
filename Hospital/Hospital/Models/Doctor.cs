using System;
using System.Collections.Generic;

#nullable disable

namespace Hospital.Models
{
    public partial class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Email { get; set; }
    }
}
