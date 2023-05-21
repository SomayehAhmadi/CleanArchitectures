using CleanArchitecture.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Mapping
{
    public static class EntityMapping
    {
        public static void AddEntityMapping<T>(this EntityTypeBuilder<T> builder)
            where T : BaseEntity
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.Property(x => x.DateCreated).IsRequired()
                .HasColumnType("datetimeoffset")
                //.HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Local))
                ;

            builder.Property(x => x.DateUpdated).IsRequired(false)
                .HasColumnType("datetimeoffset")
                //.HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Local))
                ;

            builder.Property(x => x.DateDeleted).IsRequired(false)
                .HasColumnType("datetimeoffset")
                //.HasConversion(x => xx => x != null ? DateTime.SpecifyKind(x ?? DateTime.Now, DateTimeKind.Local) : null)
                ;
        }
    }
}
