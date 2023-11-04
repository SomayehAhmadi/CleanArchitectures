using CleanArchitecture.Application.Features.AirportFeatures.GetAllFlightInfo;
using CleanArchitecture.Application.Features.AirportFeatures.GetFlight;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Repositories;

public interface IFlightRepository : IBaseRepository<Flight>
{
    Task<List<Flight>> GetById(GetAllFlightQuery getAllFlight, CancellationToken cancellationToken = default);
    public Task<List<Flight>> GetAllByPagination(GetAllFlightInfoQuery request, CancellationToken cancellationToken = default);

}
