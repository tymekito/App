using Microsoft.AspNetCore.Mvc;
using Users.Application.Abstractions;
using Users.Domain.Entities;

namespace Users.Presentation.Controllers
{
    /// <summary>
    /// Defines the <see cref="UsersController" />
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public sealed class UsersController : ControllerBase
    {
        /// <summary>
        /// Defines the _userService
        /// </summary>
        private readonly IUserService _userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="userService">The userService<see cref="IUserService"/></param>
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// The AddUser
        /// </summary>
        /// <param name="FirstName">The FirstName<see cref="string"/></param>
        /// <param name="LastName">The LastName<see cref="string"/></param>
        /// <returns>The <see cref="Task{IActionResult}"/></returns>
        [HttpPost]
        public async Task<IActionResult> AddUser(string FirstName, string LastName)
        {
            var user = new User(Guid.NewGuid(), FirstName, LastName);
            await _userService.AddUserAsync(user);
            return Ok();
        }

        /// <summary>
        /// The GetUsers
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/></returns>
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userService.GetUsersAsync();
            return Ok(result);
        }
    }
}
