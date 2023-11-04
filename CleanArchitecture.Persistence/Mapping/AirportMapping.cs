using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Mapping
{
    public class AirportMapping : IEntityTypeConfiguration<Airport>
    {
        public void Configure(EntityTypeBuilder<Airport> builder)
        {
            builder.ToTable("Airport", "TBL");
            builder.AddEntityMapping();

            builder.HasMany(x => x.Flights).WithOne(x => x.Airport).HasForeignKey(x => x.AirPortId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
