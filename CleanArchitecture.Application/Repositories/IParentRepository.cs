using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Repositories;

public interface IParentRepository : IBaseRepository<Parent>
{
    Task<Parent> GetById(long Id, CancellationToken cancellationToken);
}