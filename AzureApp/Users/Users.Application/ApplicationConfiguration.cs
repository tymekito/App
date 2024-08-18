using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
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
               .RegisterHandlers()
               .AddTransient<IUserService, UserService>();
        }

        private static IServiceCollection RegisterHandlers(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
