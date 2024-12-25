using Airline.domain.entity;
using Airline.model.dto;

namespace Airline.mapper
{
    public class FlightMapper
    {
        public FlightDto ToDto(FlightEntity flightEntity)
        {
            return new FlightDto
            {
                Id = flightEntity.Id,
                DestPoint = flightEntity.DestPoint,
                Time = flightEntity.DateTime,
                FreeSeats = flightEntity.FreeSeats
            };
        }
    }
}
