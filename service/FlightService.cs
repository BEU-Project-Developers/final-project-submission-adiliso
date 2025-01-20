using Airline.domain;
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

        public List<FlightDto> GetById(int id)
        {
            var flight = _context.Flights.Find(id);
            if (flight == null) throw new NotFoundException($"Flight not found with id: {id}");

            return [_mapper.ToDto(flight)];
        }

        public List<FlightDto> SearchFlights(FlightSearchRequest request, bool dateChecked)
        {
            var startOfDay = request.Date.ToDateTime(new TimeOnly(0, 0), DateTimeKind.Utc);
            var endOfDay = request.Date.ToDateTime(new TimeOnly(23, 59, 59), DateTimeKind.Utc);
            
            return _context.Flights
                .Where(f => f.OriginPoint == request.OriginPoint &&
                            f.DestPoint == request.DestPoint &&
                            (!dateChecked || f.DateTime >= startOfDay && f.DateTime <= endOfDay) &&
                            f.FreeSeats >= request.NumOfPassengers)
                .Select(f => _mapper.ToDto(f))
                .ToList();
        }
    }
}