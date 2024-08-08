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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var keyVaultUri = "https://funnyappkv.vault.azure.net/";
        //    // secret base on credentionals 
        //    var secretClient = new SecretClient(
        //        new Uri(keyVaultUri), 
        //        new DefaultAzureCredential());

        //    var secretName = "appSqlServerConnectionString";
        //    var secret = secretClient.GetSecret(secretName);
        //    Console.WriteLine(secret.Value.Value);    
        //    optionsBuilder.UseSqlServer(secret.Value.Value);
        //    //optionsBuilder.UseSqlServer("Server=tcp:funnyappserver.database.windows.net,1433;Initial Catalog=funnyappdb;Persist Security Info=False;User ID=funnyappadmin;Password=funnyapppassword123.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //}

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
