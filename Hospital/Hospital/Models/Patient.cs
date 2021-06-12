using System;
using System.Collections.Generic;

#nullable disable

namespace Hospital.Models
{
    public partial class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }
    }
}
