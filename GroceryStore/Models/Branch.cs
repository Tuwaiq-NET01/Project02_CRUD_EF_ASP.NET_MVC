using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        //one to many - Branch -----> BranchProduct
        public IList <BranchProduct> BranchProduct { get; set; }

    }
}
