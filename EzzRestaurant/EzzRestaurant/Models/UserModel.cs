using System.Collections.Generic;

namespace EzzRestaurant.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int PhoneNumber { get; set; }
        public string BirthDate { get; set; }
        
        public List<OrderModel> Orders { get; set; }
    }
}