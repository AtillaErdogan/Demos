using E_Ticaret.DTOs.Category;
using FluentValidation;

namespace E_Ticaret.Validation.Category
{
    public class CreateCategoryDtoValidator: AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Kategori adı boş olamaz!")
                .MinimumLength(3).WithMessage("Kategori adı minimum 3 karakter olmalıdır!")
                .MaximumLength(50).WithMessage("Kategori adı maksimum 50 karakter olabilir!");
        }
    }
}
