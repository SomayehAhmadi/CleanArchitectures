using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Mapping
{
    public class InsuranceMapping : IEntityTypeConfiguration<Insurance>
    {
        public void Configure(EntityTypeBuilder<Insurance> builder)
        {
            builder.ToTable("Insurance", "BUD");
            builder.AddEntityMapping();

            builder.Property(x => x.InsranceNum).IsRequired().HasMaxLength(100);
            builder.HasOne(x => x.ContactInfo).WithOne(x => x.Insurance).HasForeignKey<ContactInfo>(r => r.InsuranceId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Family).WithOne(x => x.Insurance).HasForeignKey<Family>(r => r.InsuranceId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
