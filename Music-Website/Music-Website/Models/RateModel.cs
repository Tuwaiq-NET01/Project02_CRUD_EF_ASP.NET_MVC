using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Website.Models
{
    public class RateModel
    {
        public int Id { get; set; }

        public int score { get; set; }

        public MusicModel Music { get; set; }

        public int MusicId { get; set; }
    }
}
