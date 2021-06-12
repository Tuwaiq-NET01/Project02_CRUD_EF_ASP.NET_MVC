using System;
using System.Collections.Generic;

#nullable disable

namespace Project03.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Availabe { get; set; }
        public decimal? Price { get; set; }
        public int? PId { get; set; }

        public virtual Publisher PIdNavigation { get; set; }
    }
}
