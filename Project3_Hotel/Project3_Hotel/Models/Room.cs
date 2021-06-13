using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Project3_Hotel.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double RoomRate { get; set; }
        public string RoomLocation { get; set; }
        public int NumberOfBeds { get; set; }

        /*public int HotelId { get; set; }//foregin key
        public Hotel Hotel { get; set; }*/

        //Many to many with reservation 
       // public IList<Rooms_Reservation> Rooms_Reservations { get; set; }
    }
}
