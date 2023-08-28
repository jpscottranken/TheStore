using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheStore.Models;

namespace TheStore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}
	}
}