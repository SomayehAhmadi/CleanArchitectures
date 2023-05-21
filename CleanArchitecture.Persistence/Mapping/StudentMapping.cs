using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Entities.EnumType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Mapping
{
    //public class UserMapping : IEntityTypeConfiguration<User>
    //{
    //    public void Configure(EntityTypeBuilder<User> builder)
    //    {
    //        builder.ToTable("User", "TBL");
    //        builder.AddEntityMapping();

    //        builder.Property(x => x.FirstName).IsRequired().HasMaxLength(250);
    //        builder.Property(x => x.LastName).IsRequired().HasMaxLength(250);
    //        builder.Property(x => x.Gender).IsRequired().HasDefaultValue(GenderType.Woman).HasColumnType("tinyint");
    //        builder.Property(x => x.DateOfBirth).IsRequired();
    //    }
    //}
    public class StudentMapping : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student", "TBL");
            builder.AddEntityMapping();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Gender).IsRequired().HasDefaultValue(GenderType.Woman).HasColumnType("tinyint");
            builder.Property(x => x.DateOfBirth).IsRequired();

            builder.Property(x => x.GradeLevel).IsRequired().HasMaxLength(250);
            builder.HasOne(x => x.ContactInfo).WithOne(x => x.Student).HasForeignKey<ContactInfo>(r => r.StudentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Family).WithMany(x => x.Students).HasForeignKey(x => x.FamilyId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
