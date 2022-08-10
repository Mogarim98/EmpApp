using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Emp.Models
{
    [Table("Departments", Schema = "HR")]

    public class Department
    {

        [Key]
        [Display(Name = "رقم الادارة")]
        public int? DepartmentId { get; set; }

        [Required]
        [Display(Name = "اسم الادارة")]
        [Column(TypeName = "nvarchar(200)")]
        public string DepartmentName { get; set; } = string.Empty;
    }
}
