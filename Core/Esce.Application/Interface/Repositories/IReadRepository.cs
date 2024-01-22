using Esce.Domain.Common;
using PagedList;
using System.Linq.Expressions;

namespace Esce.Application.Interface.Repository
{
    public interface IReadRepository<T> where T : EntityBase
    {

        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(Guid Id);

        T Get(int id);

        IQueryable<T> GetFiltered(
          Expression<Func<T, bool>> predicate = null,
          Func<IQueryable<T>, IQueryable<T>> postFilter = null,
          List<Expression<Func<T, object>>> includes = null,
          List<(Expression<Func<T, object>>, bool)> orderBy = null,
          bool enableTracking = true,
          Expression<Func<T, T>> selectColumns = null
      );
        Task<PagedList<T>> GetFilteredWithPagingAsync(
           Expression<Func<T, bool>> predicate = null,
        Func<IQueryable<T>, IQueryable<T>> postFilter = null,
        List<Expression<Func<T, object>>> includes = null,
        List<(Expression<Func<T, object>>, bool)> orderBy = null,
        bool enableTracking = true,
        int currentPage = 1,
        int pageSize = 10
            );

        Task<T> GetFirstOrDefaultAsync(
       Expression<Func<T, bool>> predicate = null,
       Func<IQueryable<T>, IQueryable<T>> postFilter = null,
       List<Expression<Func<T, object>>> includes = null,
       bool enableTracking = true
   );

        Task<IEnumerable<T>> GetFilteredAsync(
              Expression<Func<T, bool>> predicate = null,
              Func<IQueryable<T>, IQueryable<T>> postFilter = null,
              bool enableTracking = true
          );
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
    }

}
