using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models;
public class Student
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter your name")]
    [StringLength(80, ErrorMessage = "Name must contain less than 80 characters")]
    [MinLength(3, ErrorMessage = "Name must contain more than 3 characters")]
    [DisplayName("Name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your email")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;

    // Navigation property
    public List<Enrollment> Enrollment { get; set; } = new();
}
