namespace Airline.model.dto.response;

public class BookingResponse
{
    public int BookingId { get; set; }
    public int FlightId { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public DateTime FlightTime { get; set; }
    public string BookingStatus { get; set; }
}