using HotelManagement.Entitties;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DataAccessLayer
{
    public class DataContext : DbContext
    {
        // Set the tables for our DB with some properties that are of type DbSet
        public DbSet<Hotel> Hotels { get; set; } = default!;
        public DbSet<Room> Rooms { get; set; } = default!;
        public DbSet<Reservation> Reservations { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: change PocuDatabase with your Database name 
            optionsBuilder.UseSqlServer("Server =.; Database = PocuDatabase; Trusted_Connection = True");
        }
    }
}
