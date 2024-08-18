using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Users.Application;
using Users.Infrastructure;
using Users.Infrastructure.DbContexts;

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
                .RegisterUsersInfrastructureDependencies()
                .RegisterUsersApplicationDependencies()
                .RegisterUsersApplicationDependencies();
        }

        private static IServiceCollection RegisterAzureSqlDb(
            this IServiceCollection serviceCollection,
             IConfiguration configuration)
        {
            // Configure Azure Key Vault 
            var keyVaultUrl = configuration["AzureKeyVault:VaultUrl"];
            var sqlConnectingStringName = configuration["AzureKeyVault:ConnectingSqlString"];

            serviceCollection.AddDbContext<UserContext>(options =>
            {
                if (string.IsNullOrEmpty(keyVaultUrl) is false)
                {
                    var connectionString = new SecretClient(
                        new Uri(keyVaultUrl),
                        new DefaultAzureCredential())
                    .GetSecret(sqlConnectingStringName);
                    options.UseSqlServer(connectionString.Value.Value);
                }
            });

            return serviceCollection
                .RegisterUsersInfrastructureDependencies()
                .RegisterUsersApplicationDependencies();
        }
    }
}
