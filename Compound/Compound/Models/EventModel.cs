using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compound.Models
{
    public class EventModel
    {
        [Key]
        public int Event_Id { get; set; }
        [Required]
        public string Event_Name { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{dd-MM-yyyy}")]
        public DateTime? Event_Date { get; set; }

        //user-event
       // public List<User_EventModel> User_Event_list { get; set; }

        //Staff
        public StaffModel Staff { get; set; }
        public int StaffId { get; set; }

       
    }
}
