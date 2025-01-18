using SchoolSystemDemo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDb.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [ForeignKey("Role")]
        public int? RoleId { get; set; }

        [Required]
        [MaxLength(20)]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string? LastName { get; set; }

        [Required]
        [MinLength(1)]
        public bool Gender { get; set; }

        [MaxLength(255)]
        public string? Address { get; set; }
        public DateTime HireDate { get; set; }

        // relations
        // teachers => classes
        public virtual ICollection<Class>? Classes { get; set; }

        // teachers => subjects
        public virtual ICollection<Subject>? Subjects { get; set; }

        // teachers => journals
        public virtual ICollection<Journal>? Journals { get; set; }

        // teachers => schools
        public virtual ICollection<School>? Schools { get; set; }

        // teachers => schedules
        public virtual ICollection<Schedule>? Schedules { get; set; }

        // teacher => role
        public virtual Role? Role { get; set; }

    }
}
