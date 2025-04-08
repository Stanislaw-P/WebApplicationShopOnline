using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
	public interface ICartsRepository
	{
		List<Cart> GetAll();
		Cart TryGetById(Guid id);
		void Add(Product product, Guid userId);
		void IncreaseAmount(Guid productId, Guid userId);
		void DecreaseAmount(Guid productId, Guid userId);
	}
}
