using System;
using System.ComponentModel.DataAnnotations;

namespace MiniProjectMVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required]
        [Range(1, 8, ErrorMessage = "Semester must be between 1 and 8")]
        public int Semester { get; set; }

        [Required]
        [Display(Name = "Course")]
        public string Course { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Enrollment")]
        public DateTime EnrollmentDate { get; set; }
    }
}
