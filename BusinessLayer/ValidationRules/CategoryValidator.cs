using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş bırakmayınız");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage(" Açıklamayı boş bırakmayınız");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en 3 karakter girişi yapınız");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage(" Lütfen 20 karekterden fazla giriş yapmayınız");
        }
    }
}
