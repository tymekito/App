using AzureApp.SharedDomain.Results.Base;
using MediatR;

namespace AzureApp.SharedApplication.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
