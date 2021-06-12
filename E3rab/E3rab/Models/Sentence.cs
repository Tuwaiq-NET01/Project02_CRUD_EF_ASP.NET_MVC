using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace E3rab.Models
{
    public partial class Sentence
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "حقل مطلوب")]
        public string Sentence1 { get; set; }
        [Required(ErrorMessage = "حقل مطلوب")]
        public string E3rab { get; set; }
    }
}
