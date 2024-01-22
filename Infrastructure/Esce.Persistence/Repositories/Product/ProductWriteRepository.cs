using Esce.Application.Interface.Repositories;
using Esce.Domain.Entities;
using Esce.Persistence.Contexts;

namespace Esce.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(PostgreSqlDbContext dbContext) : base(dbContext)
        {
        }
    }
}
