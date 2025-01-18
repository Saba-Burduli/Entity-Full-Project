using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDb.Models
{
    public class Pupil
    {
        [Key]
        public int PupilId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "U have to enter less than 20 characters")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(30, ErrorMessage = "U have to enter less than 30 characters")]
        public string? LastName { get; set; }

        [Required]
        public DateTime DoB { get; set; }

        [Required]
        [MinLength(1)]
        public bool Gender { get; set; }
        public string? Address { get; set; }


        // relations
        // navigation: pupil => class
        [ForeignKey("Class")]
        public int? ClassId { get; set; }
        public virtual Class? Class { get; set; }

        // pupils => journals
        public virtual ICollection<Journal>? Journals { get; set; }
    }
}
