using XunitMoq.Web.Models;

namespace XunitMoq.Web.Repositories;

public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new()
    {
        new User(1, "Aleksei", DateTime.UtcNow.AddYears(-20).AddDays(20)),
        new User(2, "Olga", DateTime.UtcNow.AddYears(-18)),
        new User(3, "Dmitry", DateTime.UtcNow.AddYears(-34)),
    };

    public User? Get(int userId)
    {
        return _users.FirstOrDefault(x => x.Id == userId);
    }
}