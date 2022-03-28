using Microsoft.AspNetCore.Mvc;
using XunitMoq.Web.Models;
using XunitMoq.Web.Services;

namespace XunitMoq.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public ActionResult<User> Get(int userId)
    {
        var user = _userService.Get(userId);
        if (user is null)
            return NotFound();
        
        return Ok(_userService.Get(userId));
    }
}