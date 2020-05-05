using System;
namespace ShopTime.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public string StoreName { get; set; }
        public string Location { get; set; }
        public string LocationData { get; set; }
        public DateTime BookingTime { get; set; }
    }
}
