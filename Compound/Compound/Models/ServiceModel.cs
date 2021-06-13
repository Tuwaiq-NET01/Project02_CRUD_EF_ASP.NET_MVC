using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compound.Models
{
    public class ServiceModel
    {
        [Key]
        public int Service_Id { get; set; }
        public string Service_Name { get; set; }

        //Staff
        public StaffModel Staff { get; set; }
        public int StaffId { get; set; }

     
    }
}
