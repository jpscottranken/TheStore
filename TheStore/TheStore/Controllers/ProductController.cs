using Microsoft.AspNetCore.Mvc;
using TheStore.Models;

namespace TheStore.Controllers
{
	public class ProductController : Controller
	{
		//	Will display a single product
		public IActionResult Detail(string slugLink)
		{
			Product? product = DatabaseSimulator.GetProduct(slugLink);
			return View(product);
		}

		//	Will display our list of products
		public IActionResult List()
		{
			List<Product> products = DatabaseSimulator.GetProducts();
			return View(products);
		}
	}
}
