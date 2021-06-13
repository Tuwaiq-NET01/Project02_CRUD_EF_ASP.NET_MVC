using System.Collections.Generic;

namespace backend.Models
{
    public class Page
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Block> Blocks { get; set; }
    }
}