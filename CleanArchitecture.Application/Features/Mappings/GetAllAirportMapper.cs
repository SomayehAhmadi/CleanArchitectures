using AutoMapper;
using CleanArchitecture.Application.Features.ViewModel;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.StudentFeatures.GetAllStudent;

public sealed class GetAllAirportMapper : Profile
{
    public GetAllAirportMapper()
    {
        CreateMap<GetAllAirportViewModel, Airport>().ReverseMap();
        CreateMap<GetAllFlightViewModel, Flight>().ReverseMap();

    }
}