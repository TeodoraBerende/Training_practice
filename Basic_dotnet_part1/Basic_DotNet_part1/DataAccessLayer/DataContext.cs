using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.DataAccessLayer
{
    public class DataContext : DbContext
    {
        // Set the tables for our Database
        public DbSet<Hotel> Hotels { get; set; } = default!;
        public DbSet<Room> Rooms { get; set; } = default!;
        public DbSet<Reservation> Reservations { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = HotelManagement; Trusted_Connection = True");
        }

    }
}
