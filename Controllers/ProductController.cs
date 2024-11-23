using lr8.Models;
using Microsoft.AspNetCore.Mvc;

namespace lr8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Laptop", Price = 1500, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Smartphone", Price = 800, CreatedDate = DateTime.Now.AddDays(-1) },
                new Product { ID = 3, Name = "Tablet", Price = 300, CreatedDate = DateTime.Now.AddDays(-5) }
            };

            return View(products);
        }
    }
}
