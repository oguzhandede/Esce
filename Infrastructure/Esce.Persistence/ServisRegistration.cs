using Esce.Application.Interface.Repository;
using Esce.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Esce.Persistence
{
    public static class ServisRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductRepository, ProductRepository>();
        }
    }
}
