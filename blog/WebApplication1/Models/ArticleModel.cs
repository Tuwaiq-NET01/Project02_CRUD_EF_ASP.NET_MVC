using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ArticleModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string HTMLContent { get; set; }
        [Required]
        public string Image { get; set; }
        //user 1:m articles
        //nav
        public UserModel User { get; set; }
        public int UserId { get; set; }

        //
        public List<CommentModel> Comments { get; set; }

    }
}
