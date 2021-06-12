using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShowSqlServer.Models
{
    public class UsersModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //rel
        public List<ArtWorksModel> ArtWorks { get; set; }
        public ProfileModel Profile { get; set; }
    }
}
