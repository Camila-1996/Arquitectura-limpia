using APIPrj.Application.Interfaces;
using APIPrj.Infrastructure.Resources.Services;
using Microsoft.Extensions.DependencyInjection;

namespace APIPrj.Infrastructure.Resources
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddResourcesInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITranslator, Translator>();

            return services;
        }
    }
}
