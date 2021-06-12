using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCRUDApp.Models
{
    public class BookModel
    {
        [Key]
        public int BookID { get; set; }

        [Required(ErrorMessage = "Required .. please enter book title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please, please enter book price")]
        public float Price { get; set; }
        public int NoPage { get; set; }
        public string Notes { get; set; }


        [ForeignKey("BookStoreModel")]
        public int IdBookStore { get; set; }
        public List<Book_Author> BookAuthor { get; set; }

    }
}
