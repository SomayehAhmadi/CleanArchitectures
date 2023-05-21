using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;

public class ParentRepository : BaseRepository<Parent>, IParentRepository
{
    public ParentRepository(DataContext context) : base(context)
    {
    }

    public Task<Parent> GetById(long id, CancellationToken cancellationToken)
    {
        return Context.Parents.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}