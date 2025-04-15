namespace WebApplicationShopOnline.Models
{
	public class Product
	{
		public Product()
		{
			Id = Guid.NewGuid();
		}

		public Product(string name, string decription, decimal cost, string pathImage) :this()
		{
			Name = name;
			Decription = decription;
			Cost = cost;
			PathImage = pathImage;
		}

		public Guid Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public decimal Cost { get; set; }
		public string PathImage { get; set; }
	}
}
