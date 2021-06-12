using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Website.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string username { get; set; }
        public string Email { get; set; }

        public ProfileModel Profile { get; set; }

    }
}
