using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compound.Models
{
    public class StaffModel
    {
        [Key]
        public int Staff_Id { get; set; }
        public string Staff_Name { get; set; }
        public bool Staff_AtWork { get; set; }
        [EmailAddress][Required]
        public string Staff_Email { get; set; }
        [Phone][Required]
        public string Staff_PhoneNumber { get; set; }
        public string Staff_Img { get; set; }

        //User
        public UserModel User { get; set; }
        public int UserId { get; set; }

        //Services
        public List <ServiceModel> Services { get; set; }

        //Event
        public List<EventModel> Events { get; set; }
    }
}
