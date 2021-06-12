using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryCRUD.Models
{
    public class GalleryModel
    {
        [Key]
        public int GlrId { get; set; }
        public string GlrName { get; set; }
        public string GlrImg { get; set; }
        public string GlrLocation { get; set; }

     

    }
}




