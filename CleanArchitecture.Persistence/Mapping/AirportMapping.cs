using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CleanArchitecture.Persistence.Mapping
{
    public class AirportMapping : IEntityTypeConfiguration<Airport>
    {
        public void Configure(EntityTypeBuilder<Airport> builder)
        {
            builder.ToTable("Airport", "TBL");
            builder.AddEntityMapping();
            builder.HasKey(t => t.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasDefaultValue(0);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(250);
            builder.HasMany(x => x.Flights).WithOne(x => x.Airport).HasForeignKey(x => x.AirPortId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
