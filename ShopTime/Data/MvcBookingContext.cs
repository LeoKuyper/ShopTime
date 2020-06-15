using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopTime.Models;
using ShopTime.Models.Configuration;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());

        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ShopTime.Models.Shop> Shop { get; set; }
    }
}
