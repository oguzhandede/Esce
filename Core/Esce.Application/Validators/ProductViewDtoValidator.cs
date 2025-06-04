using Esce.Application.Dto;
using FluentValidation;

namespace Esce.Application.Validators
{
    public class ProductViewDtoValidator : AbstractValidator<ProductViewDto>
    {
        public ProductViewDtoValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().MaximumLength(100);
        }
    }
}
