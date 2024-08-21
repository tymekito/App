using AzureApp.SharedApplication.Abstractions.Messaging;

namespace Users.Application.Commands.CreateUser
{
    public sealed record CreateUserCommand(
        string FirstName,
        string LastName) : ICommand;
}
