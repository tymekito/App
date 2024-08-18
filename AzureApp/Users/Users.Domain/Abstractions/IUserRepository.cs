using Users.Domain.Entities;

namespace Users.Domain.Abstractions
{
    public interface IUserRepository
    {
        Task<IReadOnlyCollection<User>> GetAll();
        Task Add(User user);
    }
}
