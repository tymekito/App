using Microsoft.Extensions.DependencyInjection;

namespace Users.Application
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection RegisterUsersApplicationDependencies(
            this IServiceCollection serviceCollection)
        {
             return serviceCollection;
        }
    }
}
