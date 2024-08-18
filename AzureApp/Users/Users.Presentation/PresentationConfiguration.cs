using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Users.Presentation
{
    public static class PresentationConfiguration
    {

        public static IMvcBuilder RegisterUsersPresentation(this IMvcBuilder builder)
        {

            return builder.AddApplicationPart(Assembly.GetExecutingAssembly());

        }
    }
}
