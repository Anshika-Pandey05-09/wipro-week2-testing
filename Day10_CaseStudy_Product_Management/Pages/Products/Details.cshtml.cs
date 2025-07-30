using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Day10_CaseStudy_Product_Management.Pages.Products
{
    public class DetailsModel : PageModel
    {
        public Product CurrentProduct { get; set; }

        public IActionResult OnGet(int id)
        {
            // Temporary in-memory product list (simulate DB)
            var sampleProducts = new List<Product>
         {
             new Product { Id = 1, Name = "Laptop", Price = 49999 },
             new Product { Id = 2, Name = "Smartphone", Price = 29999 },
             new Product { Id = 3, Name = "Headphones", Price = 1999 }
         };

            CurrentProduct = sampleProducts.Find(p => p.Id == id);

            if (CurrentProduct == null)
                return NotFound();

            return Page();
        }
    }
}
