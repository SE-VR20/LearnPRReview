using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PRReviewProject.Pages.Product
{
    public class IndexModel : PageModel
    {
        public List<string> ProductList { get; set; }
        public void OnGet()
        {
            //int nu = Convert.ToInt32("abc");
            int nu = Convert.ToInt32
            ProductList = new List<string> { "LapTop", "Mobile", "PC", "PS" };
        }
    }
}
