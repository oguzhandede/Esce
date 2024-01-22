using Esce.Application.Interface.Repositories;
using Esce.Domain.Entities;

namespace Esce.Persistence.Repositories
{
    public class RoleReadRepository : ReadRepository<Role>, IRoleReadRepository
    {
        public RoleReadRepository(Contexts.PostgreSqlDbContext dbContext) : base(dbContext)
        {
        }
    }
}
