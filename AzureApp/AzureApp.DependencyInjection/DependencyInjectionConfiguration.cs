using Microsoft.Extensions.DependencyInjection;
using Users.Infrastructure;
using Users.Application;
using Microsoft.Extensions.Configuration;
using Users.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace AzureApp.DependencyInjection
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection RegisterDependencyInjection(
            this IServiceCollection serviceCollection,
                    IConfiguration configuration)
        {

            return serviceCollection
                .RegisterUsersDependencies()
                .RegisterAzureSqlDb(configuration);
        }

        private static IServiceCollection RegisterUsersDependencies(
            this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .RegisterUserssInfrastructureDependencies()
                .RegisterUsersApplicationDependencies();
        }

        private static IServiceCollection RegisterAzureSqlDb(
            this IServiceCollection serviceCollection,
             IConfiguration configuration)
        {
            // Configure Azure Key Vault
            var keyVaultUrl = configuration["AzureKeyVault:VaultUrl"];

            serviceCollection.AddDbContext<UserContext>(options =>
            {
                if (string.IsNullOrEmpty(keyVaultUrl) is false)
                {
                    var connectionString = new SecretClient(
                        new Uri(keyVaultUrl),
                        new DefaultAzureCredential())
                    .GetSecret("appSqlServerConnectionString");
                    options.UseSqlServer(connectionString.Value.Value);
                }
            });

            return serviceCollection
                .RegisterUserssInfrastructureDependencies()
                .RegisterUsersApplicationDependencies();
        }
    }
}
