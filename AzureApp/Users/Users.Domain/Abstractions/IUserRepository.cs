using Users.Domain.Entities;

namespace Users.Domain.Abstractions
{
    public interface IUserRepository
    {
        Task<User?> Get(Guid userId, CancellationToken cancellationToken = default);
        Task<IReadOnlyCollection<User>> GetAll(CancellationToken cancellationToken = default);
        Task Add(User user, CancellationToken cancellationToken = default);
        Task Remove(User user, CancellationToken cancellationToken = default);
    }
}
