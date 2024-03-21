using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBookingAppSample.Models
{
    public class CafeBookingAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C6KH20F\\SQLEXPRESS;Database=CafeBookingApp;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet <Reservations> Reservations { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
