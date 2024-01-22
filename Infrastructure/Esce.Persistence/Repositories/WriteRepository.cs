using Dapper;
using Esce.Application.Interface.Contexts;
using Esce.Application.Interface.Repository;
using Esce.Domain.Common;

namespace Esce.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : EntityBase
    {
        private IPostgreSqlDbContext _dbContext;

        public WriteRepository(IPostgreSqlDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }


        public async Task<bool> AddAsync(T model)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var result = await connection.ExecuteAsync($"INSERT INTO {typeof(T).Name} VALUES (@Id, @Property1, @Property2, ...)", model);
                return result > 0;
            }
        }

        public async Task<bool> AddAsync(List<T> models)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var result = await connection.ExecuteAsync($"INSERT INTO {typeof(T).Name} VALUES (@Id, @Property1, @Property2, ...)", models);
                return result > 0;
            }
        }

        public async Task<bool> Remove(T model)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var result = await connection.ExecuteAsync($"DELETE FROM {typeof(T).Name} WHERE Id = @Id", model);
                return result > 0;
            }
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var result = await connection.ExecuteAsync($"DELETE FROM {typeof(T).Name} WHERE Id = @Id", new { Id = id });
                return result > 0;
            }
        }

        public async Task<bool> UpdateAsync(T model)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var result = await connection.ExecuteAsync($"UPDATE {typeof(T).Name} SET Property1 = @Property1, Property2 = @Property2, ... WHERE Id = @Id", model);
                return result > 0;
            }
        }
    }
}
