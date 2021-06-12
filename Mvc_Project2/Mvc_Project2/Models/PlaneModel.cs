using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Project2.Models
{
    public class PlaneModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Airlines { get; set; }

        // Relationship : one-to-many Plane ------<- Passenger
        public List<PassengerModel> Passengers { get; set; }
    }
}
