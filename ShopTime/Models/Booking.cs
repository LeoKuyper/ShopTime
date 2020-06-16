using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTime.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public string OwnerId { get; set; }
        public User Owner { get; set; }

        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd-hh-mm}", ApplyFormatInEditMode = true)]
        public DateTime BookingTime { get; set; }

        public string BookingState { get; set; }

        [NotMapped]
        public List<string> Shops { get; set; }

    }
}
