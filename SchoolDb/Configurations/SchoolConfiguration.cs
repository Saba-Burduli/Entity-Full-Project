using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDb.Models;

namespace SchoolDb.Configurations
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.ToTable("Schools");

            // relations
            builder.HasMany(s => s.Teachers)
                .WithMany(t => t.Schools)
                .UsingEntity<Dictionary<string, object>>(
                "SchoolTeacher",
                right => right.HasOne<Teacher>()
                                .WithMany()
                                .HasForeignKey("TeacherId")
                                .OnDelete(DeleteBehavior.Cascade),
                left => left.HasOne<School>()
                            .WithMany()
                            .HasForeignKey("SchoolId")
                            .OnDelete(DeleteBehavior.Cascade)
                );
            
        }
    }
}
