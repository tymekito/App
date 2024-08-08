using Users.Domain.Entities;

namespace Users.Application.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task AddUserAsync(User user);
    }
}
