
using Users.Domain.Entities;

namespace Users.Application.Repositories
{
    public interface IUserRepository
    {
        Task<IReadOnlyCollection<User>> GetAll();
        Task Add(User user);
    }
}
