using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Website.Models
{
    public class MusicModel
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string audio { get; set; }

        public string Music_image { get; set; }

        public string description { get; set; }

        //Relationship : One-To-Many: Musics => Profile
        public ProfileModel Profile { get; set; }

        //FK
        public int ProfileId { get; set; }

        public RateModel Rate { get; set; }

    }
}
