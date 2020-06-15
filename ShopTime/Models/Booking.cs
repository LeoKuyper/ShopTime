using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTime.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }        

        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingTime { get; set; }

        public string BookingState { get; set; }


    }
}
