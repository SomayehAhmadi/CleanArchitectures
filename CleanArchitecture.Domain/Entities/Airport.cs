using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public class Airport : BaseEntity
    {
        public string Name { get; set; }
        public IList<Flight> Flights { get; set; }
    }
}
