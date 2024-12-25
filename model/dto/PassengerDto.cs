namespace Airline.model.dto;

public record PassengerDto
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
}