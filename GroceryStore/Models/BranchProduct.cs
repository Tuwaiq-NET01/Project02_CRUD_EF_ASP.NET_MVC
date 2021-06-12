using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class BranchProduct
    {

        //Navigation properties
        public Branch Branch { get; set; }
        public Product Product { get; set; }

        //FK
        public int BranchId { get; set; }
        public int ProductId { get; set; }
       

    }
}
