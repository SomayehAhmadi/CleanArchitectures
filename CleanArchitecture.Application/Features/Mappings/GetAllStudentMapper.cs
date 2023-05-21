using AutoMapper;
using CleanArchitecture.Application.Features.UserFeatures.GetAllUser;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.StudentFeatures.GetAllStudent;

public sealed class GetAllStudentMapper : Profile
{
    public GetAllStudentMapper()
    {
        CreateMap<GetAllStudentResponse, Student>().ReverseMap()
                 .ForMember(x => x.Gender, opt => opt.MapFrom(s => s.Gender.ToString()));

    }
}