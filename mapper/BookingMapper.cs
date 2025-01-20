using Airline.domain;
using Airline.domain.entity;
using Airline.model.dto;

namespace Airline.mapper;

public class BookingMapper
{
    public BookingDto ToDto(BookingEntity bookingEntity)
    {
        AppDbContext context = new();
        var flight = context.Flights.Find(bookingEntity.FlightId);

        return new BookingDto
        {
            BookingId = bookingEntity.Id,
            FlightId = bookingEntity.FlightId,
            From = flight.OriginPoint,
            To = flight.DestPoint,
            FlightTime = flight.DateTime,
            BookingStatus = bookingEntity.IsActive ? "Active" : "Inactive",
        };
    }
}