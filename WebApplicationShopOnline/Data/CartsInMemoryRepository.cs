using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
	public class CartsInMemoryRepository : ICartsRepository
	{
		List<Cart> carts = new List<Cart>();

		public List<Cart> GetAll()
		{
			return carts;
		}

		public Cart TryGetById(Guid userId)
		{
			return carts.FirstOrDefault(cart => cart.UserId == userId);
		}

		public void Add(Product product, Guid userId)
		{
			var existingCart = TryGetById(userId);

			if(existingCart == null)
			{
				var newCart = new Cart
				{
					Id = Guid.NewGuid(),
					Items = new List<CartItem>(),
					UserId = userId
				};
				newCart.Items.Add(addCartItem(product));

				carts.Add(newCart);
			}
			else
			{
				var existingCartItem = existingCart.Items.FirstOrDefault(item => item.Product.Id == product.Id);
				if(existingCartItem == null)
				{
					existingCart.Items.Add(addCartItem(product));
				}
				else
				{
					existingCartItem.Amount++;
				}
			}
		}

		public void IncreaseAmount(Guid productId, Guid userId)
		{
			var currentCart = TryGetById(userId);
			var currentCartItem = currentCart.Items.FirstOrDefault(item => item.Product.Id == productId);
			if (currentCart != null)
				currentCartItem.Amount++;
		}

		public void DecreaseAmount(Guid productId, Guid userId)
		{
			var currentCart = TryGetById(userId);
			var currentCartItem = currentCart.Items.FirstOrDefault(item => item.Product.Id == productId);
			if (currentCart != null)
			{
				currentCartItem.Amount--;
				if (currentCartItem.Amount == 0)
					currentCart.Items.Remove(currentCartItem);
			}
		}

		CartItem addCartItem(Product product)
		{
			return new CartItem
			{
				Id = Guid.NewGuid(),
				Product = product,
				Amount = 1
			};
		}
	}
}
