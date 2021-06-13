using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project3_Hotel.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public decimal ServiceCost { get; set; }

        //one to many with reservation
        [Required]
        public int ReservationNumber { get; set; }
        
        public Reservation Reservation { get; set; }

    }
}
