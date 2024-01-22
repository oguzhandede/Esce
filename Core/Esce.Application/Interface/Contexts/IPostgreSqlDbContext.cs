using System.Data;

namespace Esce.Application.Interface.Contexts
{
    public interface IPostgreSqlDbContext
    {
        IDbConnection GetConnection();
        void Execute(Action<IDbConnection> action);
    }
}
