using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DB_Project.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public CoacheModel Coache { get; set; }
        public int CoacheId { get; set; }
        public LeagueModel League { get; set; }
        public int LeagueId { get; set; }
        public TeamModel Team { get; set; }
        public int TeamId { get; set; }


    }
    
}
