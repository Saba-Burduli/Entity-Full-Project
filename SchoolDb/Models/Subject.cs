using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDb.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string? SubjectName { get; set; }

        // relations
        // subjects => teachers
        public virtual ICollection<Teacher>? Teachers { get; set; }

        // subjects => journals
        public virtual ICollection<Journal>? Journals { get; set; }

        // subjects => schedules
        public virtual ICollection<Schedule>? Schedules { get; set; }
    }
}
