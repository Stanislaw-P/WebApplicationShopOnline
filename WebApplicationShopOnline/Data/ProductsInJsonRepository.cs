using WebApplicationShopOnline.Models;
using System.Text.Json;

namespace WebApplicationShopOnline.Data
{
	public class ProductsInJsonRepository : IProductsRepository
	{
		List<Product> products;

		public ProductsInJsonRepository()
		{
			var jsonString = File.ReadAllText("Data/products.json");
			products = JsonSerializer.Deserialize<List<Product>>(jsonString);
		}

		public List<Product> GetAll()
		{
			return products;
		}

		public Product TryGetById(Guid id)
		{
			return products.FirstOrDefault(product => product.Id == id);
		}
	}
}
