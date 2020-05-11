using System;
namespace ShopTime.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ShopeId { get; set; }
        public string ShopLocation { get; set; }
        public string UserLocation { get; set; }
        public DateTime BookingTime { get; set; }
        public int CurrentQueue { get; set; }
    }
}
