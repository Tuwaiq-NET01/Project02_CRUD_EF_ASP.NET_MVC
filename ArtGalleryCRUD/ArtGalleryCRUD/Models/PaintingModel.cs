using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ArtGalleryCRUD.Models
{
    public class PaintingModel
    {
        [Key]
        public int PntId { get; set; }
        [Required]
        public string PntName { get; set; }
        [Required]
        public string PntImg { get; set; }
        public string PntOverview { get; set; }
        public double PntPrice { get; set; }
        



    }
}





