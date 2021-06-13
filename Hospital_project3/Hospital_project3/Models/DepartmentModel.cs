using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_project3.Models
{
    public class DepartmentModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public int PhysicianId { get; set; }
        public PhysicianModel Physician { get; set; }
    }
}
