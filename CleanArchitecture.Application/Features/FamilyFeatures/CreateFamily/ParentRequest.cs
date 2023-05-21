using CleanArchitecture.Domain.Entities.EnumType;

namespace CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily
{
    public class ParentRequest
    {
        public long FamilyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ParentContactInfoRequest ParentContactInfo { get; set; }
    }
}
