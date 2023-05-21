namespace CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily
{
    public class ContactInfoRequest
    {
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        //public long? StudentId { get; set; }
        //public long? ParentId { get; set; }
        public long? FamilyId { get; set; }
        public AddressRequest Address { get; set; }
    }
}
