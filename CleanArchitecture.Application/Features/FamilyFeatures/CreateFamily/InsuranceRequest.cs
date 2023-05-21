namespace CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily
{
    public class InsuranceRequest
    {
        public string InsranceNum { get; set; }
        public string GradeLevel { get; set; }
        public virtual int ExternalId { get; set; }
        public virtual long FamilyId { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string PolicyNumber { get; set; }
        public virtual string CompanyPhone { get; set; }
    }  
}
