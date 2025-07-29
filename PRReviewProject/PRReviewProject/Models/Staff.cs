using System.ComponentModel.DataAnnotations;

namespace PRReviewProject.Models
{
    public class Staff
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Contact")]
        [StringLength(20)]
        public string Contact { get; set; } = string.Empty;

        [Display(Name = "Email")]
        [EmailAddress]
        [StringLength(200)]
        public string? Email { get; set; }

        [Display(Name = "Department")]
        [StringLength(100)]
        public string? Department { get; set; }

        [Display(Name = "Position")]
        [StringLength(100)]
        public string? Position { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}