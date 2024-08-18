using Users.Domain.Entities;

namespace Users.Application.Abstractions
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task AddUserAsync(User user);
    }
}
