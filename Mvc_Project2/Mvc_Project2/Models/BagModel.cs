using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Project2.Models
{
    public class BagModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

        // Relationship : one-to-many : Bag  ->------ Passenger

        public int PassengerId { get; set; }
        public PassengerModel Passenger { get; set; }

    }
}
