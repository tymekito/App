using Microsoft.Extensions.DependencyInjection;
using Users.Infrastructure;
using Users.Application;

namespace AzureApp.DependencyInjection
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection RegisterDependencyInjection(
            this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .RegisterUsersDependencies();
        }

        private static IServiceCollection RegisterUsersDependencies(
            this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .RegisterUserssInfrastructureDependencies()
                .RegisterUsersApplicationDependencies();
        }
    }
}
