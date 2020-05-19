using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTime.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public bool PriorityUser { get; set; }
        public string LivingLocation { get; set; }
    }
}
