namespace CleanArchitecture.Application.Features.ViewModel
{
    public class GetAllFlightViewModel
    {
        public string LaunchMethod { get; internal set; }
        public long AirPortId { get; set; }
        public string Aircraft { get; set; }

        public DateTime? DepartureTime { get; set; }
        public short DepartureHeading { get; set; }
        public bool? DepartureInfoFound { get; set; }
    }
}
