using Esce.Application.Interface.Contexts;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace Esce.Persistence.Contexts
{
    public class PostgreSqlDbContext : IPostgreSqlDbContext
    {
        private readonly IConfiguration _configuration;

        public PostgreSqlDbContext(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public void Execute(Action<IDbConnection> action)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                action(connection);
            }
        }

        public IDbConnection GetConnection()
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            return new NpgsqlConnection(connectionString);
        }
    }
}
