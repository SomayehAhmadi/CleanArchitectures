using AutoMapper;
using CleanArchitecture.Application.Features.ViewModel;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.AirportFeatures.GetFlight
{
    public sealed class GetAllFlightQueryHandler : IRequestHandler<GetAllFlightQuery, List<GetAllFlightViewModel>>
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IMapper _mapper;

        public GetAllFlightQueryHandler(IFlightRepository flightRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllFlightViewModel>> Handle(GetAllFlightQuery request, CancellationToken cancellationToken)
        {
            var Familys = await _flightRepository.GetById(request, new CancellationToken());
            return _mapper.Map<List<GetAllFlightViewModel>>(Familys);
        }
    }

}
