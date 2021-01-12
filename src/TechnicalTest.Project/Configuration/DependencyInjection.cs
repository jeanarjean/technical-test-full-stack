using Microsoft.Extensions.DependencyInjection;

using TechnicalTest.Project.Domain;
using TechnicalTest.Project.Infrastructure.Repositories;

namespace TechnicalTest.Project.Configuration
{
    public static class DependencyInjection
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IRepository<HealthFacility>, HealthFacilityRepository>();
            services.AddScoped<IRepository<Practitioner>, PractitionerRepository>();
            services.AddScoped<IRepository<Service>, ServiceRepository>();
        }
    }
}
