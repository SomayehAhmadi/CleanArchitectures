using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Mapping
{
    public class ContactInfoMapping : IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.ToTable("ContactInfo", "TBL");
            builder.AddEntityMapping();

            builder.Property(x => x.PrimaryPhone).IsRequired().HasMaxLength(100);
            builder.Property(x => x.AlternatePhone).IsRequired().HasMaxLength(100);

        }
    }
}
