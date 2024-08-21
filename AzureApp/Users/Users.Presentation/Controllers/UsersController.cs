namespace Users.Presentation.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Users.Application.Commands.CreateUser;
    using Users.Application.Commands.RemoveUser;
    using Users.Application.Models;
    using Users.Application.Queries.GetUsers;

    /// <summary>
    /// Defines the <see cref="UsersController" />
    /// </summary>
    [ApiController]
    [Route($"api/{RoutePatterns.Users}")]
    [Produces("application/json")]
    public sealed class UsersController : ControllerBase
    {
        /// <summary>
        /// Defines the _mediator
        /// </summary>
        private readonly IMediator _mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="mediator">The mediator<see cref="IMediator"/></param>
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// The AddUser
        /// </summary>
        /// <param name="FirstName">The FirstName<see cref="string"/></param>
        /// <param name="LastName">The LastName<see cref="string"/></param>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/></param>
        /// <returns>The <see cref="Task{IActionResult}"/></returns>
        [HttpPut("new")]
        public async Task<IActionResult> AddUser(
            [FromBody] UserDto user,
            CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new CreateUserCommand(user, cancellationToken));
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
            var response = await _mediator.Send(new GetUsersQuery(cancellationToken));
            return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
        }

        /// <summary>
        /// The RemoveUser
        /// </summary>
        /// <param name="userId">The userId<see cref="Guid"/></param>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/></param>
        /// <returns>The <see cref="Task{IActionResult}"/></returns>
        [HttpDelete("{userId}")]
        public async Task<IActionResult> RemoveUser([FromRoute] Guid userId, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new RemoveUserCommand(userId, cancellationToken));
            return response.IsSuccess ? Ok(response) : NotFound(response.Error);
        }
    }
}
