using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeWars.Models
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string FirstAbility { get; set; }
        public string SecondAbility { get; set; }
        public string GifImage { get; set; }
        [ForeignKey("RankId")]
        public int RankId { get; set; }
    }
}
