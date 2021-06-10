using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookworm.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        //Relationship : One-To-Many: Users => Reviews
        public UserModel User { get; set; }

        //FK
        public int UserId { get; set; }

        //Relationship : One-To-Many: Books => Reviews
        public BookModel Book { get; set; }

        //FK
        public int BookId { get; set; }
    }
}
