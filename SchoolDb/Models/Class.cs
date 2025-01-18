using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDb.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        [Required]
        public string? ClassName { get; set; }

        // relations
        // classes => pupiles
        public virtual ICollection<Pupil>? Pupils { get; set; }

        // classes => teachers
        public virtual ICollection<Teacher>? Teachers { get; set; }

        // class => schedule
        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public virtual ICollection<Schedule>? Schedules { get; set; }
       
    }
}
