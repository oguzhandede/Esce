using Esce.Application.Dto;
using Esce.Application.Interface.Repository;
using MediatR;

namespace Esce.Application.Features.Products.Queries
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, IEnumerable<ProductViewDto>>
    {
        private readonly IProductRepository _repository;

        public GetProductListHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductViewDto>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAllAsync();
            return products.Select(p => new ProductViewDto
            {
                ProductGuid = p.ProductGuid,
                ProductName = p.ProductName
            });
        }
    }
}
