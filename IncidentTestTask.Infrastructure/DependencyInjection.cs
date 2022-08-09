using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using IncidentTestTask.Application;

namespace IncidentTestTask.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var dbName = configuration.GetValue<string>("DbName");
            services.AddDbContext<AppDbContext>(o => o.UseInMemoryDatabase(dbName));

            var dbContext = services.BuildServiceProvider().GetRequiredService<AppDbContext>();

            services.AddScoped<IIncidentRepository, IncidentRepository>();

            return services;
        }
    }
}