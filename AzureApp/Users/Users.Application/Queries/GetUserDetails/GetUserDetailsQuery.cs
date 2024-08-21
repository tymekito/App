using AzureApp.SharedApplication.Abstractions.Messaging;

namespace Users.Application.Queries.GetUserDetails
{
    public sealed record GetUserDetailsQuery(Guid UserId, CancellationToken CancellationToken) : IQuery<GetUserDetailsResponse>;
}
