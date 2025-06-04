using Esce.Application.Interface.Repository;
using Esce.Persistence.Context;
using Esce.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Esce.Persistence
{
    public static class ServisRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<PostgreSqlDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
