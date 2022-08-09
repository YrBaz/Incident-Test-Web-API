using Microsoft.Extensions.DependencyInjection;

namespace IncidentTestTask.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IIncidentService, IncidentService>();

            return services;
        }
    }
}