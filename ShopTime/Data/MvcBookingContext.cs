using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTime.Data
{
    public class MvcBookingContext : IdentityDbContext<User>
    {
        public MvcBookingContext (DbContextOptions<MvcBookingContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<User> User { get; set; }
    }
}
