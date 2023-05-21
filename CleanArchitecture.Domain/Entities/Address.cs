using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public class Address : BaseEntity
    {
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }
        public string County { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string Zip { get; private set; }
        public long ContactInfoId { get; private set; }
        public virtual ContactInfo? ContactInfo { get; private set; }


    }
}
