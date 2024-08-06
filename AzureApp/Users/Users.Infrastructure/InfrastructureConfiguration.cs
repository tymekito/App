using Microsoft.Extensions.DependencyInjection;

namespace Users.Infrastructure
{
    public static class InfrastructureConfiguration
    {
        public static IServiceCollection RegisterUserssInfrastructureDependencies(
            this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}
