using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class CartController : Controller
    {
        readonly ICartsRepository cartsRepository;
        readonly IProductsRepository productsRepository;

		public CartController(ICartsRepository cartsRepository, IProductsRepository productsRepository)
		{
			this.cartsRepository = cartsRepository;
			this.productsRepository = productsRepository;
		}

		public IActionResult Index(Guid userId)
        {
            var cart = cartsRepository.TryGetById(Constants.UserId);
            return View(cart);
        }  
        
        public IActionResult Add(Guid productId)
        {
            var existingProduct = productsRepository.TryGetById(productId);
            cartsRepository.Add(existingProduct, Constants.UserId);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult IncreaseAmount(Guid productId)
        {
            cartsRepository.IncreaseAmount(productId, Constants.UserId);
			return RedirectToAction(nameof(Index));
        }

		public IActionResult DecreaseAmount(Guid productId)
		{
			cartsRepository.DecreaseAmount(productId, Constants.UserId);
			return RedirectToAction(nameof(Index));
		}
	}
}
