using Microsoft.Extensions.DependencyInjection;
using Users.Infrastructure;
using Users.Application;
using Microsoft.Extensions.Configuration;
using Users.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;

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

            if (string.IsNullOrEmpty(keyVaultUrl) is false)
            {
                serviceCollection.AddAzureClients(builder =>
                {
                    builder.AddSecretClient(new Uri(keyVaultUrl));
                });
            }
            serviceCollection.AddDbContext<UserContext>(options =>
            {
                var connectionString = configuration["appSqlServerConnectionString"];
                options.UseSqlServer(connectionString);
            });

            return serviceCollection
                .RegisterUserssInfrastructureDependencies()
                .RegisterUsersApplicationDependencies();
        }
    }
}
