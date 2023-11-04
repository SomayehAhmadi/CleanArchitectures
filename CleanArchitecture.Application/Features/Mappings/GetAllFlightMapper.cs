using AutoMapper;
using CleanArchitecture.Application.Features.ViewModel;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.StudentFeatures.GetAllStudent;

public sealed class GetAllFlightMapper : Profile
{
    public GetAllFlightMapper()
    {
        CreateMap<GetAllFlightViewModel, Flight>().ReverseMap()
                 .ForMember(x => x.LaunchMethod, opt => opt.MapFrom(s => s.LaunchMethod.ToString()));

    }
}