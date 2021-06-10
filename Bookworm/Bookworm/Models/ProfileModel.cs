using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookworm.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(248)]
        public string Bio { get; set; }
        public string Avatar { get; set; }

        // navigation properties
        public UserModel User { get; set; }

        //FK    
        public int UserId { get; set; }
    }
}
