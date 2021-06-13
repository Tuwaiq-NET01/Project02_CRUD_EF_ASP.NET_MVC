using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compound.Models
{
    public class User_EventModel
    {
        [Key]
        public int Id { get; set; }
        public EventModel Event { get; set; }
         public int EventId { get; set; }
         public UserModel User { get; set; }
         public int UserId { get; set; }
 

    }
}
