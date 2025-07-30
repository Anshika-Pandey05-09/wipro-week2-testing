using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Day10_CaseStudy_Product_Management.Pages.Products
{
    public class IndexModel : PageModel
    {
        // List to hold products
        public List<Product>? ProductList { get; set; }
        public void OnGet()
        {
            // Here i am creating List of products to display it
            ProductList = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000 },
            new Product { Id = 2, Name = "Smartphone", Price = 500 },
            new Product { Id = 3, Name = "Tablet", Price = 300 }
        };
        }
    }
    // Product class to represent a product
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
