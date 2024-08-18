using Microsoft.Extensions.DependencyInjection;

namespace AzureApp.DependencyInjection
{
    public static class PresentationReferenceConfiguration
    {
        public static IMvcBuilder RegisterPresentationInjection(
            this IMvcBuilder serviceCollection)
        {

            return serviceCollection.AddApplicationPart(typeof(Users.Presentation.AssemblyReference).Assembly);

        }
    }

}