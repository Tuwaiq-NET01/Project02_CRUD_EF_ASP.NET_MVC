using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class CustomerProduct
    {

        //Navigation properties
        public Customer Customer { get; set; }
        public Product Product { get; set; }

        //FK
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
