using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParadiseCRUD.Models
{
    public class Flower
    {
        public int ID { get; set; }
        [Required]
        public string Image { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        public string Tempreture { get; set; }
        public string LevelCare { get; set; }
        public string Place { get; set; }
        public string Size { get; set; }

    }
}
