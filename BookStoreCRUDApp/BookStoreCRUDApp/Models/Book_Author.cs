using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCRUDApp.Models
{
    public class Book_Author
    {
        [Key]
        public int BAId { get; set; }

        [ForeignKey("BookModel")]
        public int BookID { get; set; }
        /* public BookModel BookModel { get; set; }*/
        [ForeignKey("AuthorModel")]
        public int AuthorID { get; set; }
      /*  public AuthorModel AuthorModel { get; set; }*/
    }
}
