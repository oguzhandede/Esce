using Dapper;
using Esce.Application.Interface.Contexts;
using Esce.Application.Interface.Repository;
using Esce.Domain.Common;
using Esce.Persistence.Contexts;
using PagedList;
using System.Linq.Expressions;

namespace Esce.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : EntityBase
    {
        private readonly IPostgreSqlDbContext _dbContext;
        private readonly string _tableName;
        private PostgreSqlDbContext dbContext;

        public ReadRepository(IPostgreSqlDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            //this._tableName = TableName;
        }

        public ReadRepository(PostgreSqlDbContext dbContext)
        {
            this.dbContext=dbContext;
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                return connection.Query<T>($"SELECT * FROM {typeof(T).Name}").AsQueryable();
            }
        }
        public Task<T> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }


        public IQueryable<T> GetFiltered(
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IQueryable<T>> postFilter = null,
            List<Expression<Func<T, object>>> includes = null,
            List<(Expression<Func<T, object>>, bool)> orderBy = null,
            bool enableTracking = true,
            Expression<Func<T, T>> selectColumns = null
        )
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();

                var query = $"SELECT * FROM {typeof(T).Name} ";

                if (predicate != null)
                {
                    query += $"WHERE {GetSqlPredicate(predicate)} ";
                }

                if (orderBy != null && orderBy.Any())
                {
                    query += "ORDER BY " + GetOrderBy(orderBy) + " ";
                }

                var result = connection.Query<T>(query).AsQueryable();

                if (enableTracking)
                {
                    result = result.AsQueryable();
                }

                if (postFilter != null)
                {
                    result = postFilter(result);
                }

                return result;
            }
        }
        private string GetSqlPredicate(Expression<Func<T, bool>> predicate)
        {
            // Burada expression tree'yi kullanarak lambda ifadesini SQL ifadesine çevirme işlemleri yapılabilir.
            // Bu kısmı projenizin ihtiyacına göre özelleştirebilirsiniz.
            // Örnek olarak: https://github.com/andyhutch77/DapperQueryBuilder

            // Bu örnek sadece basit bir şekilde ToString() metodunu kullanıyor.
            return predicate.ToString();
        }

        private string GetOrderBy(List<(Expression<Func<T, object>>, bool)> orderBy)
        {
            // Burada sıralama ifadelerini SQL ifadesine çevirme işlemleri yapılabilir.
            // Bu kısmı projenizin ihtiyacına göre özelleştirebilirsiniz.
            // Örnek olarak: https://github.com/andyhutch77/DapperQueryBuilder

            // Bu örnek sadece basit bir şekilde ToString() metodunu kullanıyor.
            return string.Join(", ", orderBy.Select(order => $"{order.Item1.Body} {(order.Item2 ? "ASC" : "DESC")}"));
        }

        public Task<IEnumerable<T>> GetFilteredAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IQueryable<T>> postFilter = null, bool enableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<PagedList<T>> GetFilteredWithPagingAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IQueryable<T>> postFilter = null, List<Expression<Func<T, object>>> includes = null, List<(Expression<Func<T, object>>, bool)> orderBy = null, bool enableTracking = true, int currentPage = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IQueryable<T>> postFilter = null, List<Expression<Func<T, object>>> includes = null, bool enableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }
    }
}
