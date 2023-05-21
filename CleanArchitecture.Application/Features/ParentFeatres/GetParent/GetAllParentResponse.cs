using CleanArchitecture.Domain.Entities.EnumType;

namespace CleanArchitecture.Application.Features.ParentFeatres.GetParent
{
    public class GetAllParentResponse
    {
        public long FamilyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
 
    }
}
