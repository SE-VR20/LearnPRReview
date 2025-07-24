using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PRReviewProject.Data;
using PRReviewProject.Models;

namespace PRReviewProject.Pages.Students
{
    public class AddModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AddModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; } = new Student();

        public string? Message { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Student.CreatedDate = DateTime.Now;
            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            Message = "Student added successfully!";
            
            // Clear the form after successful submission
            Student = new Student();
            
            return Page();
        }
    }
}