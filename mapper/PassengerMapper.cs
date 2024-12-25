using System.Security.Cryptography;
using System.Text;
using Airline.domain.entity;
using Airline.model.dto;
using Airline.model.dto.request;

namespace Airline.mapper;

public class PassengerMapper
{
    public PassengerDto ToDto(Passenger entity)
    {
        return new PassengerDto
        {
            Id = entity.Id,
            Username = entity.Username,
            Name = entity.Name
        };
    }

    public Passenger ToEntity(PassengerCreateRequest request)
    {
        return new Passenger
        {
            Username = request.Username,
            Name = request.Name,
            Password = HashPassword(request.Password)
        };
    }

    public string HashPassword(string password)
    {
        var inputBytes = Encoding.UTF8.GetBytes(password);
        var inputHash = SHA256.HashData(inputBytes);
        return Convert.ToHexString(inputHash);
    }
}