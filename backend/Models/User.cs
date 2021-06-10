using System;
using System.ComponentModel.DataAnnotations;

namespace PokeWars.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
