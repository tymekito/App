using Users.Application.Abstractions;
using Users.Domain.Abstractions;
using Users.Domain.Entities;

namespace Users.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userRepository.GetAll();
        }

        public async Task AddUserAsync(User user)
        {
            await _userRepository.Add(user);
        }
    }
}
