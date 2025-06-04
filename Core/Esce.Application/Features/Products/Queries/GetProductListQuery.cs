using Esce.Application.Dto;
using MediatR;

namespace Esce.Application.Features.Products.Queries
{
    public record GetProductListQuery() : IRequest<IEnumerable<ProductViewDto>>;
}
