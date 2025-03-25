﻿using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
	public interface IProductsRepository
	{
		List<Product> GetAll();
		Product TryGetById(Guid id);
	}
}