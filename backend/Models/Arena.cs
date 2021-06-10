using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeWars.Models
{
    public class Arena
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("PokemonId")]
        public int FirstPokemonId { get; set; }
        [ForeignKey("PokemonId")]
        public int SecondPokemonId { get; set; }
        [ForeignKey("PokemonId")]
        public int WinnerId { get; set; }
    }
}
