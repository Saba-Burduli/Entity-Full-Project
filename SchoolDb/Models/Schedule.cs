using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace SchoolDb.Models
{
    [Table("ClassSchedules")]
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }
        public string? DayOfWeek { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // relations

        // schedule => subject
        [ForeignKey("Subjects")]
        public int SubjectId { get; set; }
        public Subject? Subject{ get; set; }

        // schedule => teacher
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        // schedules => classes
        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public virtual Class? Class { get; set; }
    }
}
