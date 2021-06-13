using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project3_Hotel.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Status { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime ReservationDate { get; set; }

        //one to many with customer
       /* public int CustomerId { get; set; }
        public Customer Customer { get; set; }*/

        //one to many with Service
        //public ICollection<Service> Service { get; set; }

        //many to many with Rooms
      //  public IList<Rooms_Reservation> Rooms_Reservations { get; set; }
    }
}
