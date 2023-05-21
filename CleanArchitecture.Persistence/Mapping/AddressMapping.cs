using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Mapping
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address", "TBL");
            builder.AddEntityMapping();

            builder.Property(x => x.City).IsRequired().HasMaxLength(100);
            builder.Property(x => x.County).IsRequired().HasMaxLength(250);
            builder.Property(x => x.State).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Zip).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Address1).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Address2).IsRequired().HasMaxLength(500);

            builder.HasOne(x => x.ContactInfo).WithMany(x => x.Addresses).HasForeignKey(r => r.ContactInfoId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
