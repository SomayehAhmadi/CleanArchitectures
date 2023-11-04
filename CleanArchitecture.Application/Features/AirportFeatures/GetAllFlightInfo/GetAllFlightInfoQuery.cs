using CleanArchitecture.Application.Features.ViewModel;
using MediatR;

namespace CleanArchitecture.Application.Features.AirportFeatures.GetAllFlightInfo
{
    public class GetAllFlightInfoQuery : IRequest<List<GetAllFlightViewModel>>
    {
        public PaginationViewModel Pagination { get; set; }

        public string SortName { get; set; }

    }

}
