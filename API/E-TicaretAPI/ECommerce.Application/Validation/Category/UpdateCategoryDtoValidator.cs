using E_Ticaret.DTOs.Category;
using FluentValidation;

namespace ECommerce.Validation.Category
{
    public class UpdateCategoryDtoValidator :   AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryDtoValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Geçerli bir kategori ID giriniz!");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Kategori adı boş olamaz!")
                .MinimumLength(3).WithMessage("Kategori adı minimum 3 karakter olmalıdır!")
                .MaximumLength(50).WithMessage("Kategori adı maksimum 50 karakter olabilir!");
        }
    }
}
