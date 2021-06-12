using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportsSystemsCrud.Models
{
    public class AirportModel
    {
        [Key]
        public int Airport_ID { get; set; }
        [MaxLength(5)]
        public string Airport_Short { get; set; }
        public string Airport_Name { get; set; }
        public string Country_City { get; set; }
        public string Gate { get; set; }
    }
}
