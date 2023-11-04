using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Entities.EnumType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Mapping
{
    public class FlightMapping : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("Flight", "TBL");
            builder.AddEntityMapping();
            builder.Property(x => x.Aircraft).IsRequired().HasMaxLength(250);
            builder.Property(x => x.DepartureTime).IsRequired();
            builder.Property(x => x.LaunchMethod).IsRequired().HasDefaultValue(LaunchMethods.None).HasColumnType("tinyint");
            builder.Property(x => x.ArrivalTime).IsRequired();

            builder.HasOne(x => x.Airport).WithMany(x => x.Flights).HasForeignKey(x => x.AirPortId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
