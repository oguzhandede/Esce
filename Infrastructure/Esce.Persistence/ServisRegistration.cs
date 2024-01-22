using Esce.Application.Interface.Repositories;
using Esce.Application.Interface.Repository;
using Esce.Application.Interface.UnitOfWorks;
using Esce.Persistence.Repositories;
using Esce.Persistence.UnitOfWorks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data;

namespace Esce.Persistence
{
    public static class ServisRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<IDbConnection>(provider => new NpgsqlConnection(configuration.GetConnectionString("EscePostgreSql")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
