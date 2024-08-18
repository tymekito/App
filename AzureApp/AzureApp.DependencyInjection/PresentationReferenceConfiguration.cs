using Microsoft.Extensions.DependencyInjection;
using Users.Presentation;

namespace AzureApp.DependencyInjection
{
    public static class PresentationReferenceConfiguration
    {
        public static IMvcBuilder RegisterPresentationInjection(
            this IMvcBuilder builder)
        {

            return builder.RegisterUsersPresentation();

        }
    }

}