using System.ComponentModel.DataAnnotations;
using Airline.domain;
using Airline.exception;
using Airline.mapper;
using Airline.model.dto;
using Airline.model.dto.request;

namespace Airline.service;

public class PassengerService
{
    private readonly AppDbContext _context = new();

    private readonly PassengerMapper _mapper = new();


    public PassengerDto Create(PassengerCreateRequest request)
    {
        if (ExistsByUsername(request.Username))
            throw new AlreadyExistsException($"Username already exists with username: {request.Username}");

        if (request.Password != request.ConfirmPassword)
            throw new ValidationException("Passwords do not match");

        var passenger = _mapper.ToEntity(request);

        _context.Passengers.Add(passenger);
        _context.SaveChanges();

        return _mapper.ToDto(passenger);
    }

    private bool ExistsByUsername(string username)
    {
        return _context.Passengers.Any(p => p.Username == username);
    }

    public PassengerDto Login(PassengerLoginRequest request)
    {
        var passenger = _context.Passengers.FirstOrDefault(p => p.Username == request.Username);
        if (passenger == null)
            throw new ValidationException("Invalid username or password");

        if (passenger.Password != _mapper.HashPassword(request.Password))
        {
            throw new ValidationException("Invalid username or password");
        }

        return _mapper.ToDto(passenger);
    }
}