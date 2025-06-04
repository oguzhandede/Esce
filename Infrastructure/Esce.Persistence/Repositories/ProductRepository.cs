using Esce.Application.Interface.Repository;
using Esce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esce.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            // TODO: Connect to data source
            return new List<Product>();
        }
    }
}
