using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hakam.Models
{
    public class SpeakerModel
    {
        [Key]
         public int Speaker_ID { get; set; }
        public string Speeaker_Name { get; set; }
        public string Speaker_FamousFor { get; set; }
    }
}
