using Esce.Application.Interface.Contexts;
using Esce.Application.Interface.Repository;
using Esce.Application.Interface.UnitOfWorks;
using Esce.Domain.Common;
using Esce.Persistence.Repositories;

namespace Esce.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IPostgreSqlDbContext _dbContext;

        public UnitOfWork(IPostgreSqlDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async ValueTask DisposeAsync()
        {
            // Eğer burada özel bir temizleme işlemi yapmanız gerekiyorsa ekleyebilirsiniz.
            GC.SuppressFinalize(this);
        }

        public IReadRepository<T> GetReadRepository<T>() where T : EntityBase
        {
            return new ReadRepository<T>(_dbContext);
        }

        public IWriteRepository<T> IWriteRepository<T>() where T : EntityBase
        {
            return new WriteRepository<T>(_dbContext);
        }

     



        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
