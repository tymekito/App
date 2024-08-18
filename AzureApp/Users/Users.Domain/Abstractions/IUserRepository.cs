using Users.Domain.Entities;

namespace Users.Domain.Abstractions
{
    public interface IUserRepository
    {
        Task<IReadOnlyCollection<User>> GetAll(CancellationToken cancellationToken = default);
        Task Add(User user, CancellationToken cancellationToken = default);
    }
}
