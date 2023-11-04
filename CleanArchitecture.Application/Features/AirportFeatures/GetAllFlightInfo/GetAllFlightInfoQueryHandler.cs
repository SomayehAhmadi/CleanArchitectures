using AutoMapper;
using CleanArchitecture.Application.Features.ViewModel;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.AirportFeatures.GetAllFlightInfo
{
    public sealed class GetAllFlightInfoQueryHandler : IRequestHandler<GetAllFlightInfoQuery, List<GetAllFlightViewModel>>
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IMapper _mapper;

        public GetAllFlightInfoQueryHandler(IFlightRepository flightRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllFlightViewModel>> Handle(GetAllFlightInfoQuery request, CancellationToken cancellationToken)
        {
            var flights = await _flightRepository.GetAllByPagination(request, new CancellationToken());
            return _mapper.Map<List<GetAllFlightViewModel>>(flights);
        }
    }

}
