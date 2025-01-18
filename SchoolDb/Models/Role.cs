using SchoolDb.Models;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystemDemo.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [MaxLength()]
        public string RoleName { get; set; } = string.Empty;

        // relations
        public virtual ICollection<Teacher>? Teachers { get; set; }
    }
}
