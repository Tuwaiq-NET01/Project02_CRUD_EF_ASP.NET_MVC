using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookworm.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string Cover { get; set; }


        //Relationship : One-To-Many: Books => Reviews
        public List<ReviewModel> Reviews { get; set; }
    }
}
