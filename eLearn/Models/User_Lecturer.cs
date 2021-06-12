using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLearn.Models
{
    public class User_Lecturer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }

    }
}
