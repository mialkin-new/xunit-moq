using XunitMoq.Web.Models;
using XunitMoq.Web.Repositories;

namespace XunitMoq.Web.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public User? Get(int userId)
    {
        return _userRepository.Get(userId);
    }
}