using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParadiseCRUD.Models
{
    public class Comment
    {
        public int ID { get; set; }
        [Required]
        public string Message { get; set; }
        public string Name { get; set; }


    }
}
