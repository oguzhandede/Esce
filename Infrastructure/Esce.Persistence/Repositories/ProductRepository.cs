using Esce.Application.Interface.Repository;
using Esce.Domain.Entities;
using Esce.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Esce.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly PostgreSqlDbContext _context;

        public ProductRepository(PostgreSqlDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync() =>
            await _context.Products.AsNoTracking().ToListAsync();

        public async Task<Product?> GetByIdAsync(int id) =>
            await _context.Products.FindAsync(id);

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public Task<int> SaveChangesAsync() => _context.SaveChangesAsync();

    }
}
