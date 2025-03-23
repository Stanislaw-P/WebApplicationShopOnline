﻿using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
	public class ProductsRepository
	{
		static List<Product> products = new List<Product>
		{
			new Product("Чебурек с сыром", "С сыром", 120),
			new Product("Булочка", "С повидлом", 40),
			new Product("Пирожлк", "С ливером", 60),
			new Product("Шаурма", "Стандарт", 400)
		};

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
