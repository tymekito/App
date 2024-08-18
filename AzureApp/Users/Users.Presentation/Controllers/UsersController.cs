namespace Users.Presentation.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Users.Application.Commands;
    using Users.Application.Queries.GetUsers;

    /// <summary>
    /// Defines the <see cref="UsersController" />
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public sealed class UsersController : ControllerBase
    {
        /// <summary>
        /// Defines the _sender
        /// </summary>
        private readonly ISender _sender;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="sender">The sender<see cref="ISender"/></param>
        public UsersController(ISender sender)
        {
            _sender = sender;
        }

        /// <summary>
        /// The AddUser
        /// </summary>
        /// <param name="FirstName">The FirstName<see cref="string"/></param>
        /// <param name="LastName">The LastName<see cref="string"/></param>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/></param>
        /// <returns>The <see cref="Task{IActionResult}"/></returns>
        [HttpPost]
        public async Task<IActionResult> AddUser(
            string FirstName,
            string LastName,
            CancellationToken cancellationToken)
        {
            var result = await _sender.Send(new CreateUserCommand(FirstName, LastName, cancellationToken));
            return result.IsSuccess ? Ok() : BadRequest(result.Error);
        }

        /// <summary>
        /// The GetUsers
        /// </summary>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/></param>
        /// <returns>The <see cref="Task{IActionResult}"/></returns>
        [HttpGet]
        public async Task<IActionResult> GetUsers(CancellationToken cancellationToken)
        {
            var response = await _sender.Send(new GetUsersQuery(cancellationToken));
            return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
        }
    }
}
