using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryCRUD.Models
{
    public class BuyerModel
    {
        [Key]
        public int ByrID { get; set; }
        public string ByrName { get; set; }
        public string ByrMail { get; set; }
        public int ByrPhone { get; set; }

      
    }
}
