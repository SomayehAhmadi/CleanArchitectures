using CleanArchitecture.Application.Features.ViewModel;
using MediatR;

namespace CleanArchitecture.Application.Features.AirportFeatures.GetFlight
{
    public class GetAllFlightQuery : IRequest<List<GetAllFlightViewModel>>
    {
        public long AirPortId { get; set; }
        public PaginationViewModel Pagination { get; set; }

        public string SortName { get;set; }
        
    }
}
