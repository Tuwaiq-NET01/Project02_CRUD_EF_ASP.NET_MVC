using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compound.Models
{
    public class VilladModel
    {
        [Key]
        public int Villa_Id { get; set; }
        public string Villa_Name { get; set; }
        public string Villa_Group { get; set; }
        public int Villa_Number { get; set; }
        public string Villa_Img { get; set; }

        // Adding 1 to many with users
        public List<UserModel> User { get; set; }
        
    }
}
