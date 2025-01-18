using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDb.Models;

namespace SchoolDb.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teachers");

            builder.Property(t => t.HireDate)
                .HasColumnType("date");

            // relations
            builder.HasMany(t => t.Subjects)
                .WithMany(s => s.Teachers)
                .UsingEntity<Dictionary<string, object>>(
                "TeacherSubject", // join table name
            right => right.HasOne<Subject>()
                .WithMany()
                .HasForeignKey("SubjectId")
                .OnDelete(DeleteBehavior.Cascade),
            left => left.HasOne<Teacher>()
                .WithMany()
                .HasForeignKey("TeacherId")
                .OnDelete(DeleteBehavior.Cascade)
                );

            builder.HasOne(t => t.Role)
                .WithMany(r => r.Teachers)
                .HasForeignKey(t => t.RoleId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
