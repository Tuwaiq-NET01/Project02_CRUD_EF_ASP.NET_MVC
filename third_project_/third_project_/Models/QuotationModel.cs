using System;
using System.ComponentModel.DataAnnotations;

namespace third_project_.Models
{
    public class QuotationModel
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Message { get; set; }

        //navication proprties
        public int StudentId { get; set; }
        // FK
        public StudentModel Student { get; set; }
    }
}
