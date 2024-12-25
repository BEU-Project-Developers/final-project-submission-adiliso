namespace Airline.model.dto.request
{
    public class FlightSearchRequest
    {
        public string OriginPoint { get; set; }
        public string DestPoint { get; set; }
        public DateOnly Date { get; set; }
        public int NumOfPassengers { get; set; }
    }
}
