using System;
using Microsoft.EntityFrameworkCore;
using ShopTime.Models;

namespace ShopTime.Data
{
    public class MvcBookingContext : DbContext
    {
        public MvcBookingContext(DbContextOptions<MvcBookingContext> options) : base(options)
        {

        }
        public DbSet<Booking> Booking { get; set; }

    }
}
