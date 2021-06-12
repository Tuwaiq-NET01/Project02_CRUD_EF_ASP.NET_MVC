using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuwaiq_Student_Life.Models
{
    public class StudentSessionModel
    {
        public int Id { set; get; }
        public int StudentId { set; get; }
        public StudentModel Studen { set; get; }
        public int SessionId { set; get; }
        public SessionModel Instructor { set; get; }
    }
}
