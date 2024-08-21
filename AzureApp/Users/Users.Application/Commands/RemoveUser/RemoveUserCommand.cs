using AzureApp.SharedApplication.Abstractions.Messaging;

namespace Users.Application.Commands.RemoveUser
{
    public sealed record RemoveUserCommand(Guid UserId, CancellationToken CancellationToken) : ICommand;

}
