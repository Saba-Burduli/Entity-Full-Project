using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDb.Models
{
    [Table("Schools")]
    public class School
    {
        [Key]
        public int SchoolId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? SchoolName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Address { get; set; }
        public string? Phone { get; set; }

        // relations
        public virtual ICollection<Teacher>? Teachers { get; set; }
    }
}
