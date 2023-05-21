using CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily;
using MediatR;

namespace CleanArchitecture.Application.Features.StudentFeatures.CreateStudent;

public class CreateStudentRequest : IRequest<CreateStudentResponse>
{
    public List<StudentRequest> Students { get; set; }
    
}