using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3_Hotel.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        
        //one to many with billing
        public ICollection<Billing> Billing { get; set; }

        //one to many with reservation
        public ICollection<Reservation> Reservation { get; set; }
    }
}
