using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Models
{
    public class ColorModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }


        public CarOrderModel CarOrder { get; set; }
    }
}
