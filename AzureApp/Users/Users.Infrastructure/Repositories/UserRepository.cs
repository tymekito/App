using Microsoft.EntityFrameworkCore;
using Users.Domain.Abstractions;
using Users.Domain.Entities;
using Users.Infrastructure.DbContexts;

namespace Users.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public async Task Add(User user)
        {
            await _context.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
