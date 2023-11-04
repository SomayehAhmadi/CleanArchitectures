using CleanArchitecture.Application.Features.AirportFeatures.GetAirport;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Repositories;

public interface IAirportRepository : IBaseRepository<Airport>
{
    public Task<List<Airport>> GetAllByPagination(GetAllAirportQuery request, CancellationToken cancellationToken = default);
}