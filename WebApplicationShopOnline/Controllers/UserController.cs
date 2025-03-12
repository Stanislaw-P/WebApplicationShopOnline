using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index(string name, string login, string password, string phone, string email)
		{
			User inputUser = new User(name, login, password, phone, email);
			return View(inputUser);
		}
	}
}
