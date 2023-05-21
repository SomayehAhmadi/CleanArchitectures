using AutoMapper;
using CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.StudentFeatures.CreateStudent;

public sealed class FamilyMapper : Profile
{
    public FamilyMapper()
    {
        CreateMap<CreateFamilyRequest, Family>();
        CreateMap<ContactInfoRequest, ContactInfo>()
             .ForMember(x => x.ParentId, opt => opt.Ignore())
             .ForMember(x => x.StudentId, opt => opt.Ignore())
             .ForMember(x => x.FamilyId, opt => opt.Ignore())
              .ForMember(x => x.Addresses, opt => opt.MapFrom(x => new List<AddressRequest>()
                {
                    x.Address
                }))
              ;
        CreateMap<InsuranceRequest, Insurance>();
        CreateMap<StudentRequest, Student>()
            .ForMember(x => x.ContactInfo, opt => opt.MapFrom(x => x.StudentContactInfo));
        CreateMap<ParentRequest, Parent>()
             .ForMember(x => x.ContactInfo, opt => opt.MapFrom(x => x.ParentContactInfo));
        CreateMap<AddressRequest, Address>();

        CreateMap<StudentContactInfoRequest, ContactInfo>()
             .ForMember(x => x.ParentId, opt => opt.Ignore())
             //.ForMember(x => x.FamilyId, opt => opt.Ignore())
             .ForMember(x => x.Addresses, opt => opt.MapFrom(x => new List<AddressRequest>()
                {
                    x.Address
                }))
             ;
        CreateMap<ParentContactInfoRequest, ContactInfo>()
             .ForMember(x => x.StudentId, opt => opt.Ignore())
             //.ForMember(x => x.FamilyId, opt => opt.Ignore())
             .ForMember(x => x.Addresses, opt => opt.MapFrom(x => new List<AddressRequest>()
                        {
                            x.Address
                        }))
             ;
        CreateMap<CreateFamilyResponse, Family>().ReverseMap();

    }
}