using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DB_Project.Models
{
    public class CoacheModel
    {
        public int Id { get; set; }
        public int experience { get; set; }
        public string name { get; set; }
        public string nationality { get; set; }
        public List<PlayerModel> players { get; set; }
        public LeagueModel League { get; set; }
        public int LeagueId { get; set; }
        public TeamModel Team { get; set; }
        public int TeamId { get; set; }


    }
}
