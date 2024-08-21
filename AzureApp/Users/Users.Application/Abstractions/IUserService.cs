using Users.Domain.Entities;

namespace Users.Application.Abstractions
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User?> GetUserAsync(Guid userId);
        Task AddUserAsync(User user, CancellationToken cancellationToken);
        Task Remove(Guid userId, CancellationToken cancellationToken = default);
    }
}
