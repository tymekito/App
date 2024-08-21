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

        public async Task<User?> Get(Guid userId, CancellationToken cancellationToken = default)
        {
            return await _context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);
        }

        public async Task<IReadOnlyCollection<User>> GetAll(CancellationToken cancellationToken = default)
        {
            return await _context.Users.AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task Add(User user, CancellationToken cancellationToken = default)
        {
            await _context.AddAsync(user, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Remove(User user, CancellationToken cancellationToken = default)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
