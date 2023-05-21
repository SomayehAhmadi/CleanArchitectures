using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Mapping
{
    public class FamilyMapping : IEntityTypeConfiguration<Family>
    {
        public void Configure(EntityTypeBuilder<Family> builder)
        {
            builder.ToTable("Family", "TBL");
            builder.AddEntityMapping();

            builder.Property(x => x.BusinessId).IsRequired();
            builder.Property(x => x.ExternalId).IsRequired();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(250);

            builder.HasOne(x => x.ContactInfo).WithOne(x => x.Family).HasForeignKey<ContactInfo>(r => r.FamilyId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Insurance).WithOne(x => x.Family).HasForeignKey<Insurance>(r => r.FamilyId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Parents).WithOne(x => x.Family).HasForeignKey(x => x.Id).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Students).WithOne(x => x.Family).HasForeignKey(x => x.Id).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
