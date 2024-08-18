using AzureApp.SharedDomain.Results;
using AzureApp.SharedDomain.Results.Base;
using MediatR;

namespace AzureApp.SharedApplication.Abstractions.Messaging
{
    public interface ICommand : IRequest<Result>
    {
    }

    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {
    }

}
