using CleanArchitecture.Application.Features.ViewModel;
using MediatR;

namespace CleanArchitecture.Application.Features.AirportFeatures.GetAirport
{
    public class GetAllAirportQuery : IRequest<List<GetAllAirportViewModel>>
    {
        public PaginationViewModel Pagination { get; set; }

    }
}