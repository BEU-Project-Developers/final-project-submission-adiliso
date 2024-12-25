namespace Airline.exception;

public class AlreadyExistsException : Exception
{
    
    public AlreadyExistsException() { }
    
    public AlreadyExistsException(string message) : base(message) { }
    
}