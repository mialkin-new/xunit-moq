using XunitMoq.Web.Models;

namespace XunitMoq.Web.Services;

public interface IUserService
{
    User? Get(int userId);
}