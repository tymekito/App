using Microsoft.Extensions.DependencyInjection;
using Users.Application.Abstractions;
using Users.Application.Services;

namespace Users.Application
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection RegisterUsersApplicationDependencies(
            this IServiceCollection serviceCollection)
        {
             return serviceCollection
                .AddTransient<IUserService, UserService>();
        }
    }
}
