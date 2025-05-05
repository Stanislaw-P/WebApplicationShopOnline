using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
	public class AdminController : Controller
	{
		readonly IProductsRepository productsRepository;

		public AdminController(IProductsRepository productsRepository)
		{
			this.productsRepository = productsRepository;
		}

		public IActionResult Products()
		{
			var products = productsRepository.GetAll();
			return View(products);
		}

		[HttpGet]
		public IActionResult AddProduct()
		{
			return View();
		}


		[HttpPost]
		public IActionResult AddProduct(Product product)
		{
			productsRepository.Add(product);
			return RedirectToAction("Products");
		}

		public IActionResult EditProduct(Guid id)
		{
			var product = productsRepository.TryGetById(id);
			return View(product);
		}

		[HttpPost]
		public IActionResult EditProduct(Product product)
		{

		}
	}
}
