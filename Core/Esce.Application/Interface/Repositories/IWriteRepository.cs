using Esce.Domain.Common;

namespace Esce.Application.Interface.Repository
{
    public interface IWriteRepository<T> where T : EntityBase
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddAsync(List<T> model);
        Task<bool> Remove(T model);
        Task<bool> UpdateAsync(T model);
    }
}
