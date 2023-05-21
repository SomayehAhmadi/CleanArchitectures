using MediatR;

namespace CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily
{
    public class CreateFamilyRequest : IRequest<CreateFamilyResponse>
    {
        public long BusinessId { get; set; }
        public string Email { get; set; }
        public long ExternalId { get; set; }
        public InsuranceRequest Insurance { get; set; }
        public ContactInfoRequest ContactInfo { get; set; }
        public List<ParentRequest> Parents { get; set; }
        public List<StudentRequest> Students { get; set; }
    }
}
