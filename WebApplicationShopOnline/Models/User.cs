namespace WebApplicationShopOnline.Models
{
	public class User
	{
        public Guid Id { get; set; }
        public string Name { get; }
        public string Login { get; }
        public string Password { get; }
        public string Phone { get; }
		public string Email { get; set; }
		public User(string name, string login, string password, string phone, string email)
		{
			Id = Guid.NewGuid();
			Name = name;
			Login = login;
			Password = password;
			Phone = phone;
			Email = email;
		}
	}
}
