using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieCRUD.Models
{
    public class MovieModel
    {
        [Required]
        [Key] public int id { get; set; }
        [Required]
        public string backdrop_path { get; set; }
        [Required]
        public string overview { get; set; }
        [Required]
        public string poster_path { get; set; }
        [Required]
        public string release_date { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public double vote_average { get; set; }
        [Required]
        public int runtime { get; set; }
        [Required]
        public string imdb_id { get; set; }

        // Relationship Movie - Reviews
        [JsonIgnore]
        public List<ReviewModel> Reviews { get; set; }

        // Movie To Genre Relationship M-M
        [JsonIgnore]
        public List<GenreMovieModel> GenreMovie { get; set; }
        
    }
}