using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }


        // one-to-one
        //navigation propeties
        public Customer Customer { get; set; }

        //FK
        public int CustomerId { get; set; }
    }
}
