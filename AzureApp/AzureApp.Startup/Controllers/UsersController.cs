using Microsoft.AspNetCore.Mvc;
using Users.Application.Services;
using Users.Domain.Entities;

namespace AzureApp.Startup.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class UsersController : ControllerBase
    {

        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(string FirstName, string LastName)
        {
            var user = new User(Guid.NewGuid(), FirstName, LastName);
            await _userService.AddUserAsync(user);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userService.GetUsersAsync();
            return Ok(result);
        }
    }
}
