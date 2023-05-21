using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;

public class FamilyRepository : BaseRepository<Family>, IFamilyRepository
{
    public FamilyRepository(DataContext context) : base(context)
    {
    }

    //public Task<Student> GetByEmail(string email, CancellationToken cancellationToken)
    //{
    //    return Context.Students.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    //}

    public Task<Family> GetById(long id, CancellationToken cancellationToken)
    {
        return Context.Families.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}