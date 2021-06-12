using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DB_Project.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        public int numberOfPlayers { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public List<PlayerModel> players { get; set; }
        public CoacheModel Coache { get; set; }
        public LeagueModel League { get; set; }
        public int LeagueId { get; set; }

    }
}
