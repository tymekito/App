using AzureApp.SharedDomain.Results;
using MediatR;

namespace AzureApp.SharedApplication.Abstractions.Messaging
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
        where TCommand : ICommand
    {
    }
}
