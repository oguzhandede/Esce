using Esce.Application.Interface.Repository;
using Esce.Domain.Common;

namespace Esce.Application.Interface.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : EntityBase;
        IWriteRepository<T> IWriteRepository<T>() where T : EntityBase;
        Task<bool> SaveChangesAsync();

    }
}
