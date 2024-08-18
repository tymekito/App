using AzureApp.SharedApplication.Abstractions.Messaging;

namespace Users.Application.Commands
{
    public sealed record CreateUserCommand(
        string FirstName,
        string LastName,
        CancellationToken CancellationToken) : ICommand;
}
