using System.ComponentModel.DataAnnotations;

namespace HRApplication.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Name")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Please Select Department")]
        public string Department { get; set; }
        public bool isActive { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string JobTitle { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string EmailAddres { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
