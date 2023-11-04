using CleanArchitecture.Application.Features.AirportFeatures.GetAllFlightInfo;
using CleanArchitecture.Application.Features.AirportFeatures.GetFlight;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;

public partial class FlightRepository : BaseRepository<Flight>, IFlightRepository
{
    public FlightRepository(DataContext context) : base(context)
    {
    }

    public Task<List<Flight>> GetById(GetAllFlightQuery getAllFlight, CancellationToken cancellationToken)
    {
        var pagination = getAllFlight.Pagination;
        var convertProperty = typeof(Flight).GetProperty(getAllFlight.SortName);

        return Context.Flights.Where(e => e.AirPortId == getAllFlight.AirPortId).Skip(pagination.Offset > 0 ? (pagination.Offset * pagination.Limit) : 0)
                .Take(pagination.Limit)
                .OrderByDescending(n => (convertProperty.GetValue(n) ?? string.Empty).ToString())
                .ToListAsync();
    }
    public Task<List<Flight>> GetAllByPagination(GetAllFlightInfoQuery getAllFlight, CancellationToken cancellationToken = default)
    {
        var pagination = getAllFlight.Pagination;
        var convertProperty = typeof(Flight).GetProperty(getAllFlight.SortName);

        return Context.Flights.Skip(pagination.Offset * pagination.Limit).Take(pagination.Offset)
            .OrderByDescending(n => (convertProperty.GetValue(n) ?? string.Empty).ToString())
            .ToListAsync(cancellationToken);
    }

}