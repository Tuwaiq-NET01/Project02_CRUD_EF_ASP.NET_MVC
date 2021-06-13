using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NadaMVC.Models
{
    public class BookModel
    {
        [Required]
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Title { get; set; }
        public int Published { get; set; }
        public string image { get; set; }

        public BookModel(int BookId, string Author, string Title, int Published, string image)
        {
            this.BookId = BookId;
            this.Author = Author;
            this.Title = Title;
            this.Published = Published;
            this.image = image;
        }
    }
}
