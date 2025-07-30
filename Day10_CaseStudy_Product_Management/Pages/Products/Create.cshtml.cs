using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Day10_CaseStudy_Product_Management.Pages.Products
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Product NewProduct { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // For now, just redirect to Index after "adding"
            // In real app: Save to DB or memory
            return RedirectToPage("Index");
        }
    }
}
