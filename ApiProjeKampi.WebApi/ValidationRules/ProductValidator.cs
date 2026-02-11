using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=> x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin");
            RuleFor(x=> x.ProductName).MinimumLength(2).WithMessage("En az iki karakter girin.");
            RuleFor(x=> x.ProductName).MaximumLength(50).WithMessage("En fazla elli karakter girin.");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş olamaz.").GreaterThan(0).WithMessage("Ürün fiyatı negatif olamaz");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("ürün açıklaması boş olmaz.");
        }
    }
}
