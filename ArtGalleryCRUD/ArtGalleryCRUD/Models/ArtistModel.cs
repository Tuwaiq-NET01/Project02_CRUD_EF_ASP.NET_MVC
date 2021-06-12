using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryCRUD.Models
{
    public class ArtistModel
    {
        [Key]
        public int ArtId { get; set; }
        public string ArtName { get; set; }
        public string ArtImg { get; set; }
        public string ArtBio { get; set; }

    
    }
}