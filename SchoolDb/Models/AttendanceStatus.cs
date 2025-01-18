using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDb.Models
{
    [Table("AttendanceStatuses")]
    public class AttendanceStatus
    {
        [Key]
        public int AttendanceStatusId { get; set; }

        [Required]
        public string? AttendanceStatusName { get; set; }

        // relations
        // attendanceStatus => jouirnal
        public virtual ICollection<Journal>? Journals { get; set; }
    }
}
