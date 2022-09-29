using Microsoft.AspNetCore.Mvc;
using MVC_Intro_Demo.Models;
using System.Text;
using System.Text.Json;

namespace MVC_Intro_Demo.Controllers
{
    public class ProductsController : Controller
    {
      private  IEnumerable<ProductViewModel> products = new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id = 1,
                Name = "Cheese",
                Price = 7.00
            },
            new ProductViewModel()
            {
                Id = 2,
                Name = "Ham",
                Price = 5.50
            },
            new ProductViewModel()
            {
                Id = 3,
                Name = "Bread",
                Price = 1.50
            }

        };

        [HttpGet]
        [ActionName("My-Products")]
        public IActionResult All(string keyword)
        {
            if (keyword != null)
            {
                var selectedProducts = products.Where(p => p.Name.ToLower().Contains(keyword.ToLower()));
                return View(selectedProducts);
            }
            return View(products);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            ProductViewModel pr = products.FirstOrDefault(x => x.Id == id);

            if (pr == null)
            {
                return BadRequest();
            }
            else
            {
                return View(pr);
            }
        }

        [HttpGet]
        public IActionResult GetAllAsJson()
        {
            var oprions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            return Json(products, oprions);
        }

        [HttpGet]
        public IActionResult GetAllAsText()
        {

            return Content(GetProducts()); 
        }

        public IActionResult Download()
        {
            string products = GetProducts();

            Response.Headers.Add("content-disposition", "attachment; filename=products.txt");

           
            return File(
                Encoding.UTF8.GetBytes(products), "text/plain");
        }

        private string GetProducts()
        {
            var sb = new StringBuilder();

            foreach (var pr in products)
            {
                sb.AppendLine($"{pr.Id}. {pr.Name} - {pr.Price}");
            }

            return sb.ToString().Trim();
        }
    }
}
