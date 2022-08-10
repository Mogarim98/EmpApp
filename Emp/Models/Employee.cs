using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Emp.Models
{
    [Table("Employees",Schema ="HR")]
    public class Employee
    {
        [Key]
        [Display(Name ="رقم الموظف")]
        public int? EmployeeId { get; set; }

        [Required]
        [Display(Name ="اسم الموظف")]
        [Column(TypeName ="nvarchar(200)")]
        public string EmployeeName { get; set; }    = string.Empty;

        [Display(Name = "الصورة")]
        [Column(TypeName = "nvarchar(250)")]
        public string? ImageUser { get; set; } = string.Empty;

        [Display(Name = "تاريخ الميلاد")]
         [DataType(DataType.DateTime)]
        // [DisplayFormat(DataFormatString = "0:dd/MM/yyyy")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "الراتب")]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Salary { get; set; }

        [Display(Name = "تاريخ التعيين")]
        [DataType(DataType.DateTime)]
     // [DisplayFormat(DataFormatString ="0:dd/MM/yyyy")]
        public DateTime HiringDate { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        [Display(Name ="الجنسية")]
        [Column(TypeName ="varchar(10)")]
    
        public string NationalId { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
         [Display(Name = "الإدارة")]
       public Department? Department { get; set; }


    }
}
