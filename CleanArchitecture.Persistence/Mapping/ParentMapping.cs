using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Entities.EnumType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Mapping
{
    public class ParentMapping : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            builder.ToTable("Parent", "TBL");
            builder.AddEntityMapping();

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Gender).IsRequired().HasDefaultValue(GenderType.Woman).HasColumnType("tinyint");
            builder.Property(x => x.DateOfBirth).IsRequired();

            builder.HasOne(x => x.ContactInfo).WithOne(x => x.Parent).HasForeignKey<ContactInfo>(r => r.ParentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Family).WithMany(x => x.Parents).HasForeignKey(x => x.FamilyId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
