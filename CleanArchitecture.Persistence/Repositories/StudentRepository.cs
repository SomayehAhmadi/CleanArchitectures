using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    public StudentRepository(DataContext context) : base(context)
    {
    }

    public Task<Student> GetById(long id, CancellationToken cancellationToken)
    {
        return Context.Students.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}
