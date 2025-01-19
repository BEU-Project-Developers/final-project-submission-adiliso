namespace Airline.model.dto
{
    public record FlightDto
    {
        public int Id { get; set; }
        public string OriginPoint { get; set; }
        public string DestPoint { get; set; }
        public DateTime Time { get; set; }
        public int FreeSeats { get; set; }
    }
}
