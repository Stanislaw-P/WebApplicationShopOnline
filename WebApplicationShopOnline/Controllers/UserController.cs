using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
	public class UserController : Controller
	{
		UserRepository userRepository = new UserRepository();

		public IActionResult Index(Guid idUser)
		{
			var existingUser = userRepository.TryGetById(idUser);
			if (existingUser == null)
				return NotFound();
			return View(existingUser);
		}

		// Норм название не придумал
		public IActionResult UserList()
		{
			var users = userRepository.GetAll();
			return View(users);
		}
	}
}
