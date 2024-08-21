using AzureApp.SharedDomain.Results;
using AzureApp.SharedDomain.Results.Base;
using MediatR;

namespace AzureApp.SharedApplication.Abstractions.Messaging
{
    // Command with default Result
    public interface ICommand : IRequest<Result>
    {
    }

    // Command with T Result
    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {
    }

}
