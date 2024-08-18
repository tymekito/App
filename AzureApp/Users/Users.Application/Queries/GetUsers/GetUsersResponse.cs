using Users.Application.Models;

namespace Users.Application.Queries.GetUsers
{
    public sealed record GetUsersResponse(IReadOnlyCollection<UserDto> response);
}
