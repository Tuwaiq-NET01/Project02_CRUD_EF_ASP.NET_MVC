using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CommentModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Date { get; set; }

        //article 1:m comment
        //nav
        public ArticleModel Article { get; set; }
        public int ArticleId { get; set; }

    }
}
