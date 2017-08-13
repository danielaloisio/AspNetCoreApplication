using AspNetCoreApplication.Data.Entities;
using AspNetCoreApplication.Data.Model;
using FluentValidation;

namespace AspNetCoreApplication.Data
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage(ProductMessage.Validation.Name);
        }
    }
}
