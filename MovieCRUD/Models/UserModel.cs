using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieCRUD.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ProfilePic { get; set; }
        
        [JsonIgnore]
        public List<ReviewModel> Reviews { get; set; }

    }
}