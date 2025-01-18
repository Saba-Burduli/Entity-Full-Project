using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDb.Models;

namespace SchoolDb.Configurations
{
    public class JournalConfiguration : IEntityTypeConfiguration<Journal>
    {
        public void Configure(EntityTypeBuilder<Journal> builder)
        {
            builder.ToTable("Journals");

            builder.Property(j => j.RegistrationDate)
                .HasColumnType("date");

            // relations
            // journal => pupil
            builder.HasOne(j => j.Pupil)
                .WithMany(p => p.Journals)
                .HasForeignKey(j => j.PupilId)
                .OnDelete(DeleteBehavior.Restrict);

            // journal => subject
            builder.HasOne(j=>j.Subject)
                .WithMany(s=>s.Journals)
                .HasForeignKey(j=>j.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            // journal => teacher
            builder.HasOne(j=>j.Teacher)
                .WithMany(t=>t.Journals)
                .HasForeignKey(j=>j.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            // journal => grade
            builder.HasOne(j => j.Grade)
                .WithMany(g => g.Journals)
                .HasForeignKey(j => j.GradeId)
                .OnDelete(DeleteBehavior.Restrict);

            // journal => attendanceStatus
            builder.HasOne(j => j.AttendanceStatus)
                .WithMany(a => a.Journals)
                .HasForeignKey(j => j.AttendanceStatusId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
