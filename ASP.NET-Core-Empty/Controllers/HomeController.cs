using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Empty.Controllers
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
