using Esce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Esce.Persistence.Context
{
    /// <summary>
    ///     Application database context configured for PostgreSQL.
    /// </summary>
    public class PostgreSqlDbContext : DbContext
    {
        public PostgreSqlDbContext(DbContextOptions<PostgreSqlDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Brand> Brands => Set<Brand>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
