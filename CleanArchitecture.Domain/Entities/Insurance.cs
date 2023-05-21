using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public class Insurance : BaseEntity
    {
        public string InsranceNum { get; set; }
        public string GradeLevel { get; private set; }
        public virtual int ExternalId { get; private set; }
        public virtual long FamilyId { get; private set; }
        public virtual string CompanyName { get; private set; }
        public virtual string PolicyNumber { get; private set; }
        public virtual string CompanyPhone { get; private set; }
        public virtual ContactInfo? ContactInfo { get; private set; }
        public virtual Family? Family { get; private set; }
    }
}
