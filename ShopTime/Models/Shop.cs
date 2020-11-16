using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTime.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int ActiveCashiers { get; set; }
        public int MaxCapacity { get; set; }

        public ICollection<Booking> Bookings { get; set; }

    }
}
