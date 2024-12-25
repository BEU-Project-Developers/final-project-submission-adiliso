using Airline.domain.entity;
using Microsoft.EntityFrameworkCore;

namespace Airline.domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<FlightEntity> Flights { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5436;Database=postgres;Username=postgres;Password=1234;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define unique constraint for Passenger.Username
            modelBuilder.Entity<Passenger>()
                .HasIndex(p => p.Username)
                .IsUnique();

            // Define relationships
            modelBuilder.Entity<BookingEntity>()
                .HasOne<FlightEntity>()
                .WithMany()
                .HasForeignKey(b => b.FlightId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}