using XunitMoq.Web.Models;

namespace XunitMoq.Web.Repositories;

public interface IUserRepository
{
    public User? Get(int userId);
}