using AzureApp.SharedApplication.Abstractions.Messaging;
using AzureApp.SharedDomain.Results;
using Users.Domain.Abstractions;
using Users.Domain.Entities;

namespace Users.Application.Commands.CreateUser
{
    public sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(
            IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userId = Guid.NewGuid();
            var user = new User(userId, request.User.FirstName, request.User.LastName);
            await _userRepository.Add(user, cancellationToken);

            return Result.Success(userId);
        }
    }
}
