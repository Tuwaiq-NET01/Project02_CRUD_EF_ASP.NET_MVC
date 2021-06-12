using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLearn.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int Id { get; set; }
        [MaxLength(10)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<User_Lecturer> User_Lecturer { get; set; }
        public List<User_Course> User_Course { get; set; }
    }
}
