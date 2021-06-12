using System;
using System.Collections.Generic;

#nullable disable

namespace Logistic.Models
{
    public partial class Shipment
    {
        public int Id { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public string LocationOfDelivery { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
