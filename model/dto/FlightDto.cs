namespace Airline.model.dto
{
    public record FlightDto
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Time { get; set; }
        public int FreeSeats { get; set; }
    }
}
