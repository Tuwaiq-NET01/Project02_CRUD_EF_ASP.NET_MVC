using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DB_Project.Models
{
    public class LeagueModel
    {
        public int Id { get; set; }
        public int numberOfTeams { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public List<PlayerModel> players { get; set; }
        public List<CoacheModel> Coaches { get; set; }
        public List<TeamModel> Teams { get; set; }
    }
}
