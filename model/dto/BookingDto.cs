namespace Airline.model.dto;

public class BookingDto
{
    public int Id { get; set; }
    public string Passenger { get; set; }
    public int FlightId { get; set; }
    public string Status { get; set; }
}