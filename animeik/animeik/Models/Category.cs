using System.Collections.Generic;

namespace animeik.Models
{
    public class Category
    {
        public int Categoryid { get; set; }
        public string Name { get; set; }

        public List<Anime> Animes { get; set; }
    }
}