using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hakam.Models
{
    public class PodcastModel
    {
        [Key]
         public int Podcast_ID { get; set; }
        public string Podcast_Name { get; set; }
        public string Podcast_Logo { get; set; }
        public string Podcast_Link { get; set; }
         [ForeignKey("Speaker_ID")]
        public int Speaker_ID { get; set; }
 
    }
}
