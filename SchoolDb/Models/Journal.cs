using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDb.Models
{
    [Table("Journals")]
    public class Journal
    {
        [Key]
        public int JournalId { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        // relations
        // journal => teacher
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }
        public virtual Teacher? Teacher { get; set; }

        // journal => subject
        [ForeignKey("Subjects")]
        public int SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }

        // journal => pupil
        [ForeignKey("Pupils")]
        public int PupilId { get; set; }
        public virtual Pupil? Pupil { get; set; }

        // journal => grade
        [ForeignKey("Grades")]
        public int GradeId { get; set; }
        public virtual Grade? Grade { get; set; }

        // journal => attendanceStatus
        [ForeignKey("AttendanceStatus")]
        public int AttendanceStatusId { get; set; }
        public virtual AttendanceStatus? AttendanceStatus { get; set; }
    }
}
