using System;
using System.Collections.Generic;

#nullable disable

namespace Project03.Models
{
    public partial class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
