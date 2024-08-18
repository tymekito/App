using AzureApp.SharedApplication.Abstractions.Messaging;

namespace Users.Application.Queries.GetUsers
{
    public sealed record GetUsersQuery(CancellationToken CancellationToken) : IQuery<GetUsersResponse>;
}
