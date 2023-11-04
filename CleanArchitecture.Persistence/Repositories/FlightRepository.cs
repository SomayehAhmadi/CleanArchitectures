using CleanArchitecture.Application.Features.AirportFeatures.GetAllFlightInfo;
using CleanArchitecture.Application.Features.AirportFeatures.GetFlight;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CleanArchitecture.Persistence.Repositories;

public partial class FlightRepository : BaseRepository<Flight>, IFlightRepository
{
    public FlightRepository(DataContext context) : base(context)
    {
    }

    public Task<List<Flight>> GetById(GetAllFlightQuery getAllFlight, CancellationToken cancellationToken)
    {
        var pagination = getAllFlight.Pagination;
     
        var orderPredicate = MapToSort(getAllFlight.SortName);  

        return Context.Flights.AsNoTracking().Where(e => e.AirPortId == getAllFlight.AirPortId).Skip((pagination.Page - 1) * pagination.PageSize)
                .Take(pagination.PageSize)
                .OrderBy(orderPredicate)
                .ToListAsync();
    }

    public Task<List<Flight>> GetAllByPagination(GetAllFlightInfoQuery getAllFlight, CancellationToken cancellationToken = default)
    {
        var pagination = getAllFlight.Pagination;

        var orderPredicate = MapToSort(getAllFlight.SortName);


        return Context.Flights.AsNoTracking().Skip((pagination.Page - 1) * pagination.PageSize).Take(pagination.PageSize)
            .OrderBy(orderPredicate)
            .ToListAsync(cancellationToken);
    }

    #region Private methods
    private Expression<Func<Flight, object>> MapToSort(string sortName)
    {
        var param = Expression.Parameter(typeof(Flight));
        var memberAccess = Expression.Property(param, sortName);
        var convertedMemberAccess = Expression.Convert(memberAccess, typeof(object));
        var orderPredicate = Expression.Lambda<Func<Flight, object>>(convertedMemberAccess, param);
        return orderPredicate;
    }

    #endregion

}