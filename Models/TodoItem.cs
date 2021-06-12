using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace Project03_CRUD_With_ASP.NET_MVC.Models
{
    public class TodoItem
    {
        [RequiredAttribute]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool What { get; set; }
        public bool Where { get; set; }
        public bool When { get; set; }
        public bool Why { get; set; }
        public bool How { get; set; }
        public TodoItem(string name, bool What, bool Why, bool When, bool Where, bool How)
        {
            this.Name = name;
            this.What = What;
            this.Where = Where;
            this.When = When;
            this.Why = Why;
            this.How = How;
        }
        public TodoItem() { }
    }
}