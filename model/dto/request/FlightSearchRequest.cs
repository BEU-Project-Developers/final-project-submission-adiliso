namespace Airline.model.dto.request
{
    public class FlightSearchRequest(string originPoint, string destPoint, DateOnly date, int numOfPassengers)
    {
        public string OriginPoint { get; } = originPoint.ToUpper();
        public string DestPoint { get; } = destPoint.ToUpper();
        public DateOnly Date { get; } = date;
        public int NumOfPassengers { get; } = numOfPassengers;
    }
}