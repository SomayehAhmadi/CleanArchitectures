using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities.EnumType;

namespace CleanArchitecture.Domain.Entities
{
    public class Parent : BaseEntity
    {
        public long FamilyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ContactInfo? ContactInfo { get; private set; }
        public virtual Family? Family { get; private set; }

    }
}
