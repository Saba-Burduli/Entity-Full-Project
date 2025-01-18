using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDb.Models
{
    [Table("Grades")]
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }

        [Required]
        public string? GradeName { get; set; }

        // relations
        // grade => journal
        public virtual ICollection<Journal>? Journals { get; set; }
    }
}
