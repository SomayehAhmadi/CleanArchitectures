using CleanArchitecture.Application.Features.AirportFeatures.GetAirport;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;

public class AirportRepository : BaseRepository<Airport>, IAirportRepository
{
    public AirportRepository(DataContext context) : base(context)
    {
    }

    public Task<List<Airport>> GetAllByPagination(GetAllAirportQuery request, CancellationToken cancellationToken = default)
    {
        var pagination = request.Pagination;
        return Context.Airports.AsNoTracking().Skip((pagination.Page-1) * pagination.PageSize).Take(pagination.PageSize)
            .ToListAsync(cancellationToken);
    }
}
