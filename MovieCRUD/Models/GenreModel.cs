using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieCRUD.Models
{
    public class GenreModel
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        
        // Movie To Genre Relationship M-M
        [JsonIgnore]
        public List<GenreMovieModel> GenreMovie { get; set; }
    }
}