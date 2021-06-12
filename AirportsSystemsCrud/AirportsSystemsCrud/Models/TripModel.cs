using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportsSystemsCrud.Models
{
    public class TripModel
    {
        [Key]
        public int TripID { get; set; }
        public string Trip_Type { get; set; }
        public int Price { get; set; }
        public int Take_Off_Time { get; set; }
        public string Cabin_Class { get; set; }
        public int Duration { get; set; }
        public string Road_Type { get; set; }
        public int Weight { get; set; }
        public string Destination { get; set; }
    }
}
