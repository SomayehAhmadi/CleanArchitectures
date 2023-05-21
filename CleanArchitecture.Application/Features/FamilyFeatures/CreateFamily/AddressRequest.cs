namespace CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily
{
    public class AddressRequest
    {
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public long ContactInfoId { get; set; }
    }
}
