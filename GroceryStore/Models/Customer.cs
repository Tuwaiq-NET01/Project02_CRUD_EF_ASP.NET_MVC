using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        // one-to-one
        //navigation propeties
        public User User { get; set; }

        //one to many - Customer -----> CustomerProduct
        public IList<CustomerProduct> CustomerProduct { get; set; }

    }
}
