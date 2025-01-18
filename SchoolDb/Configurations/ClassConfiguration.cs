using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDb.Models;

namespace SchoolDb.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Classes");

            // relations
            // classes => teachers = many-to-many
            builder.HasMany(c => c.Teachers)
                .WithMany(t => t.Classes)
                .UsingEntity<Dictionary<string, object>>(
                "ClassTeacher",
            right => right.HasOne<Teacher>()
                .WithMany()
                .HasForeignKey("TeacherId") // foreign key for Teacher
                .OnDelete(DeleteBehavior.Cascade),
            left => left.HasOne<Class>()
                .WithMany()
                .HasForeignKey("ClassId")// foreign key for Class
                .OnDelete(DeleteBehavior.Cascade)
            );

        }
    }
}
