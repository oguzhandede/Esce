using Esce.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Esce.Application.Interface.Repository
{
    public interface IProductRepository
    {

        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task<int> SaveChangesAsync();

    }
}
