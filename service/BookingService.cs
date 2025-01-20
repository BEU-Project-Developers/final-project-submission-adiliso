using Airline.domain;
using Airline.domain.entity;
using Airline.exception;
using Airline.mapper;
using Airline.model.dto;
using Microsoft.EntityFrameworkCore;

namespace Airline.service;

public class BookingService
{
    private readonly AppDbContext _context = new();

    private readonly BookingMapper _mapper = new();

    public BookingDto CreateBooking(int flightId)
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
                "You can't buy a ticket on this flight. The plane will take off in less than 10 minutes");

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

    public List<BookingDto> ShowMyBookings()
    {
        return _context.Bookings
            .Where(b => b.Passenger == FormsHelper.CURRENT_PASSENGER.Username)
            .Select(b => _mapper.ToDto(b))
            .ToList();
    }

    public List<BookingDto> ShowActiveBookings()
    {
        return _context.Bookings
            .Where(b => b.Passenger == FormsHelper.CURRENT_PASSENGER.Username && b.IsActive)
            .Select(b => _mapper.ToDto(b))
            .ToList();
    }

    public void UpdateBookingsStatus()
    {
        var currentDate = DateTime.UtcNow;

        _context.Bookings
            .Join(_context.Flights,
                b => b.FlightId,
                f => f.Id,
                (b, f) => new { Booking = b, Flight = f })
            .Where(bf => bf.Booking.IsActive && bf.Flight.DateTime < currentDate)
            .Select(bf => bf.Booking)
            .ExecuteUpdate(b => b.SetProperty(entity => entity.IsActive, false));

        /*
        1. Joins the Bookings and Flights tables based on the FlightId in the Bookings table
            and the Id in the Flights table, creating a combined result with Booking and Flight data.
        2. Filters the joined data to include only active bookings (Booking.IsActive is true)
            for flights that have a DateTime earlier than the specified currentDate.
        3. Selects the matching bookings (Booking entities) from the filtered results.
        4. Executes a batch update on the selected bookings, setting the IsActive property to false,
            effectively marking these bookings as inactive in the database.
         */
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