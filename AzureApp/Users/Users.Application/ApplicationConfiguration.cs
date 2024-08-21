using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Users.Application
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection RegisterUsersApplicationDependencies(
            this IServiceCollection serviceCollection)
        {
            return serviceCollection
               .RegisterHandlers();
        }

        private static IServiceCollection RegisterHandlers(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
