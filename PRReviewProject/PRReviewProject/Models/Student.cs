using System.ComponentModel.DataAnnotations;

namespace PRReviewProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Range(16, 65)]
        public int Age { get; set; }

        [StringLength(100)]
        public string? Course { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}