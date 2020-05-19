using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTime.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ShopId { get; set; }
        public DateTime BookingTime { get; set; }
        public int CurrentQueue { get; set; }


    }
}
