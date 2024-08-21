using AzureApp.SharedApplication.Abstractions.Messaging;
using AzureApp.SharedDomain.Results;
using Users.Domain.Abstractions;
using Users.Domain.Exceptions;

namespace Users.Application.Commands.RemoveUser
{
    public class RemoveUserCommandHandler : ICommandHandler<RemoveUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public RemoveUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Result> Handle(RemoveUserCommand command, CancellationToken cancellationToken)
        {
            var user = await _userRepository.Get(command.UserId);

            if (user == null)
            {
                throw new UserNotFoundException(command.UserId);
            }

            await _userRepository.Remove(user, cancellationToken);

            return Result.Success(command.UserId);
        }
    }
}
