using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public class Family:BaseEntity
    {
        public Family()
        {
            Parents = new List<Parent>();
            Students = new List<Student>();
        }

        public long BusinessId { get; private set; }
        public string Email { get; private set; }
        public long ExternalId { get; private set; }
        public long InsuranceId { get; private set; }
        public virtual ContactInfo? ContactInfo { get; private set; }
        public virtual Insurance? Insurance { get; private set; }

        public virtual IList<Parent> Parents { get; private set; }
        public virtual IList<Student> Students { get; private set; }

    }
}
