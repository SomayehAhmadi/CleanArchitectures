using AutoMapper;
using CleanArchitecture.Application.Features.ViewModel;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.AirportFeatures.GetAirport
{
    public class GetAllAirportQueryHandler : IRequestHandler<GetAllAirportQuery, List<GetAllAirportViewModel>>
    {
        private readonly IAirportRepository _airportRepository;
        private readonly IMapper _mapper;

        public GetAllAirportQueryHandler(IAirportRepository airportRepository, IMapper mapper)
        {
            _airportRepository = airportRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllAirportViewModel>> Handle(GetAllAirportQuery request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var airPorts = await _airportRepository.GetAllByPagination(request);
            return _mapper.Map<List<GetAllAirportViewModel>>(airPorts);
        }
    }
}
