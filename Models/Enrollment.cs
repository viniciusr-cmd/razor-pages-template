using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models;
public class Enrollment
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the course name")]
    [StringLength(80, ErrorMessage = "Course name must contain less than 80 characters")]
    [MinLength(3, ErrorMessage = "Course name must contain more than 3 characters")]
    [DisplayName("Course name")]
    public string CourseName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter the course code")]
    [StringLength(5, ErrorMessage = "Course code must contain less than 5 characters")]
    [MinLength(3, ErrorMessage = "Course code must contain more than 3 characters")]
    [DisplayName("Course code")]
    public string CourseCode { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [DisplayName("Enrollment date")]
    public DateTime StartDate { get; set; }

    [DataType(DataType.Date)]
    [DisplayName("Completion date")]
    public DateTime EndDate { get; set; }

    // Foreign key
    [DisplayName("Student ID")]
    [Required(ErrorMessage = "Please enter the student id")]
    public int StudentId { get; set; }

    // Navigation property
    public Student? Student { get; set; } = new();
}
