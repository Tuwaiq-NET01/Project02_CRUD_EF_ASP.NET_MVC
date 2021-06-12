using System.Collections.Generic;

namespace GroceryStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }

        //one to many - product -----> BranchProduct
        public IList<BranchProduct> BranchProduct { get; set; }

        //one to many - Product -----> CustomerProduct
        public IList<CustomerProduct> CustomerProduct { get; set; }



    }
}
