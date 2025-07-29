using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PRReviewProject.Pages.Product
{
    public class IndexModel : PageModel
    {
        public List<string> ProductList { get; set; } = new();
        public void OnGet()
        {
            ProductList = new List<string> { "LapTop", "Mobile", "PC", "PS" };
        }
    }
}
