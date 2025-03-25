using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
	public class ProductController : Controller
	{
		readonly IProductsRepository productsRepository;

		public ProductController(IProductsRepository productsRepository)
		{
			this.productsRepository = productsRepository;
		}

		public IActionResult Index(Guid id)
		{
			Product product = productsRepository.TryGetById(id);
			return View(product);
		}

		public IActionResult Catalog()
		{
			var products = productsRepository.GetAll();
			return View(products);
		}
	}
}
