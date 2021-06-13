using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project3_Hotel.Models
{
    public class Billing
    {
        [Key]
        public int BillingNumber { get; set; }
        public decimal RoomCharge { get; set; }
        public int CreditCardNumber { get; set; }
        public DateTime PaymentDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
