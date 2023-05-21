using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Repositories;

public interface IStudentRepository : IBaseRepository<Student>
{
    Task<Student> GetById(long Id, CancellationToken cancellationToken);
}
