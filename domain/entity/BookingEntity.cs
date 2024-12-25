using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airline.domain.entity
{
    public class BookingEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Passenger { get; set; } // Foreign key reference to Passenger.Username

        [ForeignKey("FlightEntity")]
        public int FlightId { get; set; } // Foreign key to FlightEntity.Id

        public bool IsActive { get; set; }
    }
}
