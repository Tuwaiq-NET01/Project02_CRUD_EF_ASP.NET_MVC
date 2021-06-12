using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCRUDApp.Models
{
    public class AuthorModel
    {
        [Key]
        public int AuthorID { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorEmail { get; set; }
        public string Notes { get; set; }

        public List<Book_Author> BookAuthor { get; set; }
    }
}
