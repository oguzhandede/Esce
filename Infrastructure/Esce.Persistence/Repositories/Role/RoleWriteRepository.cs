using Esce.Application.Interface.Contexts;
using Esce.Application.Interface.Repositories;
using Esce.Domain.Entities;

namespace Esce.Persistence.Repositories
{
    public class RoleWriteRepository(IPostgreSqlDbContext dbContext) : WriteRepository<Role>(dbContext), IRoleWriteRepository
    {
    }
}
