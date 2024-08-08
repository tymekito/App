using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.EntityFrameworkCore;
using Users.Domain.Entities;

namespace Users.Infrastructure.DbContexts
{
    public class UserContext : DbContext 
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(eb =>
            {
                eb.HasKey(x => x.Id);
                eb.Property(x => x.FirstName).IsRequired().HasDefaultValue("");  
                eb.Property(x => x.LastName).IsRequired().HasDefaultValue("");
            });

            modelBuilder.Entity<Address>(eb =>
            {
                eb.HasKey(x => x.Id);
            });
        }
    }

}
