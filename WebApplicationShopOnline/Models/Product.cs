namespace WebApplicationShopOnline.Models
{
	public class Product
	{
		public Product(string name, string decription, decimal cost)
		{
			Id = Guid.NewGuid();
			Name = name;
			Decription = decription;
			Cost = cost;
		}

		public Guid Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public decimal Cost { get; set; }
    }
}
