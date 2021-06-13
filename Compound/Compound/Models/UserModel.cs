using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compound.Models
{
    public class UserModel
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        [EmailAddress][Required]
        public string User_Email { get; set; }
        [Phone][Required]
        public string User_PhoneNumber { get; set; }


        //Villa
        public VilladModel Villa { get; set; }
        public int VillaId { get; set; }

        //Staff
        public List<StaffModel> Staff { get; set; }


        //user-event
        //public List<User_EventModel> User_Event_list { get; set; }


    }
}
