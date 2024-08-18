using AzureApp.SharedDomain.Results;
using AzureApp.SharedDomain.Results.Base;
using MediatR;

namespace AzureApp.SharedApplication.Abstractions.Messaging
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
        where TCommand : ICommand
    {
    }

    public interface ICommandHandler<TCommand, TResponse>
        : IRequestHandler<TCommand, Result<TResponse>>
        where TCommand : ICommand<TResponse>
    {
    }

}
