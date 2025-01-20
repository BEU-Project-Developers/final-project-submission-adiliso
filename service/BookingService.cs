using Airline.domain;
using Airline.domain.entity;
using Airline.exception;
using Airline.mapper;
using Airline.model.dto;
using Airline.model.dto.response;
using Microsoft.EntityFrameworkCore;

namespace Airline.service;

public class BookingService
{
    private readonly AppDbContext _context = new();

    private readonly BookingMapper _mapper = new();

    public BookingDto createBooking(int flightId)
    {
        var flight = _context.Flights.Find(flightId);

        if (flight == null)
            throw new NotFoundException($"Flight not found with id {flightId}");
        if (flight.FreeSeats == 0)
            throw new BadRequestException("There are no free seats available on this flight");
        if (flight.DateTime < DateTime.Now)
            throw new BadRequestException("This flight is out of date");
        if (flight.DateTime < DateTime.Now.AddMinutes(10))
            throw new BadRequestException(
                "You cannot buy a ticket on this flight. The plane will take off in less than 10 minutes");

        flight.FreeSeats--;
        _context.Flights.Update(flight);

        var bookingEntity = new BookingEntity
        {
            Passenger = FormsHelper.CURRENT_PASSENGER.Username,
            FlightId = flight.Id,
            IsActive = true
        };
        _context.Bookings.Add(bookingEntity);

        _context.SaveChanges();

        return _mapper.ToDto(bookingEntity);
    }

    public List<BookingResponse> ShowMyBookings()
    {
        return _context.Bookings
            .Where(b => b.Passenger == FormsHelper.CURRENT_PASSENGER.Username)
            .Select(b => _mapper.ToResponse(b))
            .ToList();
    }

    public List<BookingResponse> ShowActiveBookings()
    {
        return _context.Bookings
            .Where(b => b.Passenger == FormsHelper.CURRENT_PASSENGER.Username && b.IsActive)
            .Select(b => _mapper.ToResponse(b))
            .ToList();
    }

    public void UpdateBookingsStatus()
    {
        var currentDate = DateTime.UtcNow;

        _context.Bookings
            .Where(b => b.IsActive && _context.Flights
                .Where(f => f.DateTime < currentDate)
                .Select(f => f.Id)
                .Contains(b.FlightId))
            .ExecuteUpdate(b => b.SetProperty(b => b.IsActive, false));
    }

    public void CancelBooking(int bookingId)
    {
        var booking = _context.Bookings.Find(bookingId);

        if (booking == null || booking.Passenger != FormsHelper.CURRENT_PASSENGER.Username)
            throw new NotFoundException($"Booking not found with id {bookingId}");

        if (!booking.IsActive)
            throw new BadRequestException("This booking is not active");

        booking.IsActive = false;
        _context.Bookings.Update(booking);
        _context.SaveChanges();
    }
}