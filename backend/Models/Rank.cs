using System.ComponentModel.DataAnnotations.Schema;

namespace PokeWars.Models
{
    public class Rank
    {
        public int Id { get; set; }
        public int Place { get; set; }
        [ForeignKey("PokemonId")]
        public int PokemonId { get; set; }
    }
}
