using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportsSystemsCrud.Models
{
    public class PlaneModel
    {
        [Key]
        public int Plane_ID { get; set; }
        public int Capacity { get; set; }
        public string Plane_Name { get; set; }
        public string Plane_Type { get; set; }
    }
}
