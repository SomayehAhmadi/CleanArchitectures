using CleanArchitecture.Domain.Entities.EnumType;

namespace CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily
{
    public class StudentRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GradeLevel { get; set; }
        public long FamilyId { get; set; }
        public ContactInfoRequest StudentContactInfo { get; set; }

    }
}
