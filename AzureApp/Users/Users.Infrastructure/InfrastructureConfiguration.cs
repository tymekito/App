using Microsoft.Extensions.DependencyInjection;
using Users.Domain.Abstractions;
using Users.Infrastructure.Repositories;

namespace Users.Infrastructure
{
    public static class InfrastructureConfiguration
    {
        public static IServiceCollection RegisterUsersInfrastructureDependencies(
            this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IUserRepository, UserRepository>();
        }
    }
}
