using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hakam.Models
{
    public class UserModel
    {
        [Key]
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Password { get; set; }
        public string User_Email { get; set; }
    }
}
