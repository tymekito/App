using AzureApp.SharedApplication.Abstractions.Messaging;
using Users.Application.Models;

namespace Users.Application.Commands.CreateUser
{
    public sealed record CreateUserCommand(
        UserDto User,
        CancellationToken CancellationToken) : ICommand;
}
