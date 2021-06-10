using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookworm.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        
        // navigation properties
        public ProfileModel Profile { get; set; }

        //Relationship : One-To-Many: Users => Reviews
        public List<ReviewModel> Reviews { get; set; }
    }
}
