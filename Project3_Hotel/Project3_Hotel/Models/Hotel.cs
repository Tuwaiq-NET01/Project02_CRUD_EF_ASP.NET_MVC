using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3_Hotel.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public int Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PhoneNumber { get; set; }

        //one to many (one Hotel has many Rooms)
        public ICollection<Room> Room { get; set; }
    }
}
