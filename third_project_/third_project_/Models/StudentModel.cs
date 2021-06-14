using System;
using System.Collections.Generic;

namespace third_project_.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //RelationShip
        public List<QuotationModel> Quotations { get; set; }
    }
}
