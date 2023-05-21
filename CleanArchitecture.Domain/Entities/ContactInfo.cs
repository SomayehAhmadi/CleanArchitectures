using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public class ContactInfo:BaseEntity
    {
        public ContactInfo()
        {
            Addresses = new List<Address>();
        }

        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public long? StudentId { get; set; }
        public long? ParentId { get; set; }
        public long? FamilyId { get; set; }
        public long? InsuranceId { get; set; }
        public virtual IList<Address> Addresses { get; private set; }
        public virtual Student Student { get; private set; }
        public virtual Parent Parent { get; private set; }
        public virtual Family Family { get; private set; }
        public virtual Insurance Insurance { get; private set; }

    }
}
