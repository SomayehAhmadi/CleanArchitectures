using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.ViewModel
{
    public class GetAllAirportViewModel
    {
        public string Name { get; set; }
        public IList<Flight> Flights { get; set; }
    }
}
