using Microsoft.AspNetCore.Mvc;
using User.Business.Abstract;
namespace User.API.Controllers;

[Route("users/")]
public class UsersController : Controller
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }
    
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        List<Entities.User> users = _userService.GetAllUsers();
        return Ok(users);
    }

    [HttpGet("user/{id}")]
    public IActionResult Get(int id)
    {
        Entities.User user = _userService.GetUserById(id);
        return Ok(user);
    }
    [HttpGet("delete/{id}")]
    public IActionResult Delete(int id)
    {
        _userService.DeleteUser(id);
        return Ok();
    }
    
    [HttpPost("add/")]
    public IActionResult Add([FromBody]Entities.User user)
    {
        return Ok(_userService.CreateUser(user));
    }



    [HttpPost("update/")]
    public IActionResult Update([FromBody]Entities.User user)
    {
        return Ok(_userService.UpdateUser(user));
    }
}