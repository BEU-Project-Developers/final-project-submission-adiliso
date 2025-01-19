using Airline.domain;
using Airline.domain.entity;
using Airline.model.dto;
using Airline.model.dto.response;

namespace Airline.mapper;

public class BookingMapper
{
    public BookingDto ToDto(BookingEntity bookingEntity)
    {
        return new BookingDto
        {
            Id = bookingEntity.Id,
            Passenger = bookingEntity.Passenger,
            FlightId = bookingEntity.FlightId,
            Status = bookingEntity.IsActive ? "Active" : "Cancelled",
        };
    }

    public BookingResponse ToResponse(BookingEntity bookingEntity)
    {
        AppDbContext context = new();
        var flight = context.Flights.Find(bookingEntity.FlightId);

        return new BookingResponse
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