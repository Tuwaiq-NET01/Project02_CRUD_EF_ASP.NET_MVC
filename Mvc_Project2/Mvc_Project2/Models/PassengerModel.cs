using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Project2.Models
{
    public class PassengerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }

        // Relationship : one-to-many : Passenger  ->------ Plane

        public int PlaneId { get; set; }
        public PlaneModel Plane { get; set; }

        // Relationship : one-to-many Passenger ------<- Bag
        public List<BagModel> Bags { get; set; }
    }
}
