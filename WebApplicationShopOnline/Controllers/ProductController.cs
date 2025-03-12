using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			Product product = new Product("Пирожок", "С вишней вкусный свежий", 90);
			return View(product);
		}
	}
}
