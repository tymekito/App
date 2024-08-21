using AzureApp.SharedApplication.Abstractions.Messaging;
using AzureApp.SharedDomain.Results;
using Users.Application.Abstractions;

namespace Users.Application.Commands.RemoveUser
{
    public class RemoveUserCommandHandler : ICommandHandler<RemoveUserCommand>
    {
        private readonly IUserService _userService;

        public RemoveUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<Result> Handle(RemoveUserCommand command, CancellationToken cancellationToken)
        {
            var user = await _userService.GetUserAsync(command.UserId);
            await _userService.Remove(command.UserId, cancellationToken);

            return Result.Success(command.UserId);
        }
    }
}
