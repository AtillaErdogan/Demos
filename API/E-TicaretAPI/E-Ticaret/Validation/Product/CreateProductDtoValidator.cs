using E_Ticaret.DTOs.Product;
using FluentValidation;

namespace E_Ticaret.Validation.Product
{
    public class CreateProductDtoValidator : AbstractValidator<CreateProductDto>
    {
        public CreateProductDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Ürün adı boş olamaz!")
                .MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır!");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Ürün fiyatı 0'dan büyük olmalıdır!");

            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("Lütfen geçerli bir kategori seçiniz!");
        }
    }
}
