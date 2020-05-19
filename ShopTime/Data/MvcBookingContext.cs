using Microsoft.EntityFrameworkCore;
using ShopTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTime.Data
{
    public class MvcBookingContext : DbContext
    {
        public MvcBookingContext (DbContextOptions<MvcBookingContext> options) : base(options)
        {

        }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<User> User { get; set; }
    }
}
