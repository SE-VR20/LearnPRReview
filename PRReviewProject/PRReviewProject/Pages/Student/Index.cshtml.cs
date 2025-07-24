using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PRReviewProject.Pages.Student
{
    public class IndexModel : PageModel
    {
        public string StudentName { get; set; } = "John Doe";
        public string StudentId { get; set; } = "STU123456";
        public string Email { get; set; } = "john.doe@university.edu";
        public string Major { get; set; } = "Computer Science";
        public string Year { get; set; } = "Senior";
        public double GPA { get; set; } = 3.75;

        public void OnGet()
        {
            // Page model initialization happens here
            // In a real application, this would typically load data from a database
        }
    }
}