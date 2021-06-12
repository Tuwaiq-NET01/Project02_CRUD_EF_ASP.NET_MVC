using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CRUD_ASP_PROJECT.Models
{
    public partial class AnimeModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        public string Image { get; set; }
        public string Story { get; set; }
        public string Video { get; set; }
    }
}
