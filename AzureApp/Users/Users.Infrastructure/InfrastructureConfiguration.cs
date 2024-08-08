using Microsoft.Extensions.DependencyInjection;
using Users.Application.Repositories;
using Users.Infrastructure.DbContexts;
using Users.Infrastructure.Repositories;

namespace Users.Infrastructure
{
    public static class InfrastructureConfiguration
    {
        public static IServiceCollection RegisterUserssInfrastructureDependencies(
            this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IUserRepository, UserRepository>();
        }
    }
}
