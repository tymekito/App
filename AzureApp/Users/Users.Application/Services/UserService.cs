using Users.Application.Abstractions;
using Users.Domain.Abstractions;
using Users.Domain.Entities;
using Users.Domain.Exceptions;

namespace Users.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> GetUserAsync(Guid userId)
        {
            return await _userRepository.Get(userId);
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userRepository.GetAll();
        }

        public async Task AddUserAsync(User user, CancellationToken cancellationToken)
        {
            await _userRepository.Add(user, cancellationToken);
        }

        public async Task Remove(Guid userId, CancellationToken cancellationToken = default)
        {
            var user = await _userRepository.Get(userId);

            if (user == null)
            {
                throw new UserNotFoundException(userId);
            }

            await _userRepository.Remove(user, cancellationToken);
        }
    }
}
