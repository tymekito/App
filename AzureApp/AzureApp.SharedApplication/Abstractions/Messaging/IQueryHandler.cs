using AzureApp.SharedDomain.Results.Base;
using MediatR;

namespace AzureApp.SharedApplication.Abstractions.Messaging
{
    public interface IQueryHandler<TQuery, TResponse>
        : IRequestHandler<TQuery, Result<TResponse>>
        where TQuery : IQuery<TResponse>
    {
    }
}
