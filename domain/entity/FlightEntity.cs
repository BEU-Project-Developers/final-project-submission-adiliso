using System.ComponentModel.DataAnnotations;

namespace Airline.domain.entity
{
    public record FlightEntity
    {
        [Key]
        public int Id { get; set; }
        public string OriginPoint { get; set; }
        public string DestPoint { get; set; }
        public DateTime DateTime { get; set; }
        public int TotalSeats { get; set; }
        public int FreeSeats { get; set; }
    }
}
