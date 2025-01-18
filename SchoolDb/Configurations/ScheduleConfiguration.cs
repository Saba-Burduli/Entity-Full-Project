using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDb.Models;

namespace SchoolDb.Configurations
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.ToTable("Schedules");

            // relations
            // schedule => class
            builder.HasOne(s => s.Class)
                .WithMany(c=>c.Schedules)
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            // schedule => subject
            builder.HasOne(sch => sch.Subject)
                .WithMany(s => s.Schedules)
                .HasForeignKey(sch => sch.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            // schedule => teacher
            builder.HasOne(sch => sch.Teacher)
                .WithMany(t => t.Schedules)
                .HasForeignKey(sch => sch.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
