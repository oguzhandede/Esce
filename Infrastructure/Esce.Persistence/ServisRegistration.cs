using Esce.Application.Interface.Repository;
using Esce.Persistence.Context;
using Esce.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Esce.Persistence
{
    public static class ServisRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<PostgreSqlDbContext>();

            services.AddScoped<IProductRepository, ProductRepository>();

            // Register additional repositories using AddScoped as they are implemented
        }
    }
}
