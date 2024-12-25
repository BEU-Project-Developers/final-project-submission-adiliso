using System.Diagnostics;
using Airline.domain;
using Airline.domain.entity;
using Airline.exception;
using Airline.mapper;
using Airline.model.dto;
using Airline.model.dto.request;

namespace Airline.service
{
    public class FlightService
    {
        private readonly AppDbContext _context = new();

        private readonly FlightMapper _mapper = new();

        public List<FlightDto> ShowIn24Hours()
        {
            var currentTime = DateTime.UtcNow;
            var futureTime = currentTime.AddHours(24);

            return _context.Flights
                .Where(f => f.DateTime >= currentTime && f.DateTime <= futureTime)
                .Select(f => _mapper.ToDto(f))
                .ToList();
        }

        public FlightDto GetById(int id)
        {
            var flight = _context.Flights.Find(id);
            if (flight == null) throw new NotFoundException($"Flight not found with id: {id}");

            return _mapper.ToDto(flight);
        }

        public List<FlightDto> SearchFlights(FlightSearchRequest request)
        {
            var startOfDay = request.Date.ToDateTime(TimeOnly.MinValue, DateTimeKind.Utc);
            var endOfDay = startOfDay.AddDays(1);

            return _context.Flights
                .Where(f => f.OriginPoint == request.OriginPoint &&
                            f.DestPoint == request.DestPoint &&
                            f.DateTime >= startOfDay && f.DateTime <= endOfDay &&
                            f.FreeSeats >= request.NumOfPassengers)
                .Select(f => _mapper.ToDto(f))
                .ToList();
        }

        //Using this method you can get flights for testing.
        public void AddFlights()
        {
            var flights = new List<FlightEntity>
            {
                new FlightEntity
                {
                    OriginPoint = "New York", DestPoint = "Los Angeles",
                    DateTime = new DateTime(2025, 2, 1, 12, 0, 0, DateTimeKind.Utc), TotalSeats = 200, FreeSeats = 150
                },
                new FlightEntity
                {
                    OriginPoint = "London", DestPoint = "Paris",
                    DateTime = new DateTime(2025, 2, 2, 14, 0, 0, DateTimeKind.Utc), TotalSeats = 180, FreeSeats = 100
                },
                new FlightEntity
                {
                    OriginPoint = "Tokyo", DestPoint = "Seoul",
                    DateTime = new DateTime(2025, 2, 3, 16, 0, 0, DateTimeKind.Utc), TotalSeats = 220, FreeSeats = 200
                },
                new FlightEntity
                {
                    OriginPoint = "Sydney", DestPoint = "Melbourne",
                    DateTime = new DateTime(2025, 2, 4, 18, 0, 0, DateTimeKind.Utc), TotalSeats = 150, FreeSeats = 120
                },
                new FlightEntity
                {
                    OriginPoint = "Toronto", DestPoint = "Vancouver",
                    DateTime = new DateTime(2025, 2, 5, 20, 0, 0, DateTimeKind.Utc), TotalSeats = 160, FreeSeats = 130
                },
                new FlightEntity
                {
                    OriginPoint = "Dubai", DestPoint = "Mumbai",
                    DateTime = new DateTime(2025, 2, 6, 22, 0, 0, DateTimeKind.Utc), TotalSeats = 250, FreeSeats = 90
                },
                new FlightEntity
                {
                    OriginPoint = "Berlin", DestPoint = "Rome",
                    DateTime = new DateTime(2025, 2, 7, 0, 0, 0, DateTimeKind.Utc), TotalSeats = 140, FreeSeats = 60
                },
                new FlightEntity
                {
                    OriginPoint = "Madrid", DestPoint = "Barcelona",
                    DateTime = new DateTime(2025, 2, 8, 2, 0, 0, DateTimeKind.Utc), TotalSeats = 170, FreeSeats = 80
                },
                new FlightEntity
                {
                    OriginPoint = "Singapore", DestPoint = "Bangkok",
                    DateTime = new DateTime(2025, 2, 9, 4, 0, 0, DateTimeKind.Utc), TotalSeats = 230, FreeSeats = 180
                },
                new FlightEntity
                {
                    OriginPoint = "Rio de Janeiro", DestPoint = "Buenos Aires",
                    DateTime = new DateTime(2025, 2, 10, 6, 0, 0, DateTimeKind.Utc), TotalSeats = 190, FreeSeats = 110
                }
            };

            _context.Flights.AddRange(flights);
            _context.SaveChanges();
        }
    }
}