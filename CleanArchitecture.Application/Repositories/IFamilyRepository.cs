using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Repositories;

public interface IFamilyRepository : IBaseRepository<Family>
{
    Task<Family> GetById(long Id, CancellationToken cancellationToken);
}