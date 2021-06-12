using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Website.Models
{
    public class ProfileModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Background_Image { get; set; }

        public UserModel User { get; set; }

        public int UserId { get; set; }

        public List<MusicModel> Musics { get; set; }



    }
}
