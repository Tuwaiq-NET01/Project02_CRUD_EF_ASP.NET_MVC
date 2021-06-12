using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShowSqlServer.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public int Phone_Number { get; set; }


        // rel
        public UsersModel User { get; set; }
        public int UserId { get; set; }
    }
}
