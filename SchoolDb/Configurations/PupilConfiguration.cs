using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDb.Models;

namespace SchoolDb.Configurations
{
    public class PupilConfiguration : IEntityTypeConfiguration<Pupil>
    {
        // Fluent API
        public void Configure(EntityTypeBuilder<Pupil> builder)
        {
            builder.ToTable("Pupils");

            builder.Property(p => p.DoB)
                .HasColumnType("date");

            // relations
            // configuration for one-many relations: pupil => class
            builder.HasOne(p => p.Class)
                .WithMany(c => c.Pupils)
                .HasForeignKey(p => p.ClassId);
        }
    }
}
