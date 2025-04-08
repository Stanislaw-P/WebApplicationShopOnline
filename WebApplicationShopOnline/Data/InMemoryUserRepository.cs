using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
	public class InMemoryUserRepository : IUsersRepository
	{
		static List<User> users = new List<User>
		{
			new User("Stas", "Admin1", "Aa123456", "+79999999", "email@com"),
			new User("Anna", "Admin2", "Aa123456", "+7229339", "email@com"),
			new User("Alan", "Alan4ik", "Aa123456", "+444444", "alan254@google.com"),
		};

		public List<User> GetAll()
		{
			return users;
		}

		public User TryGetById(Guid id)
		{
			return users.FirstOrDefault(user => user.Id == id);
		}
	}
}
