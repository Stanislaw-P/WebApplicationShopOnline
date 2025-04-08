namespace WebApplicationShopOnline.Models
{
	public class Cart
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public List<CartItem> Items { get; set; }
		public decimal Cost => Items.Sum(x => x.Cost);
	}
}
