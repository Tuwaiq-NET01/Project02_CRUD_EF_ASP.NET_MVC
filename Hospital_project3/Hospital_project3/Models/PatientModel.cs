using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_project3.Models
{
    public class PatientModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int NationalID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public List<AppointmentModel> Appointments { get; set; }
    }
}
