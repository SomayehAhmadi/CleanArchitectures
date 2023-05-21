using AutoMapper;
using CleanArchitecture.Application.Features.ParentFeatres.CreateParent;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.StudentFeatures.CreateStudent;

public sealed class CreateStudentMapper : Profile
{
    public CreateStudentMapper()
    {
        CreateMap<CreateStudentRequest, Student>();
        CreateMap<Student, CreateStudentResponse>();
        CreateMap<Int64, CreateStudentResponse>().ReverseMap();
    }
}
public sealed class ParentMapper : Profile
{
    public ParentMapper()
    {
        CreateMap<CreateParentRequest, Parent>();
        
        CreateMap<bool, CreateStudentResponse>().ReverseMap();
    }
}