using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hakam.Models
{
    public class QuoteModel
    {
        [Key]
        public int Qoute_ID { get; set; }
        public string Quote { get; set; }
        [ForeignKey("Speaker_ID")]
        public int Speaker_ID { get; set; }
    }
}
