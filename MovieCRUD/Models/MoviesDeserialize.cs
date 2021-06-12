using System.Collections.Generic;

namespace MovieCRUD.Models
{
    public class MoviesDeserialize
    {
            public int id { get; set; }
            public string backdrop_path { get; set; }
            public string overview { get; set; }
            public string poster_path { get; set; }
            public string release_date { get; set; }
            public string title { get; set; }
            public double vote_average { get; set; }
            public int runtime { get; set; }
            public string imdb_id { get; set; }
            
            public List<Genre> genres { get; set; }
        }

        public class Genre
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Root
        {
            public List<MoviesDeserialize> results { get; set; }
            public List<Genre> genres { get; set; }
        }
    }
