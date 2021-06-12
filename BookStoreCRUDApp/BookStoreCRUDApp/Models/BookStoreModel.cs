using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCRUDApp.Models
{
    public class BookStoreModel
    {

        [Key]
        public int IdBookStore { get; set; }
        public string NameOfBookStore { get; set; }
        public string Location { get; set; }
        public string EmailOfBookStore { get; set; }
        public string Telephone { get; set; }

        public List<BookModel> BookModel { get; set; }
    }
}
