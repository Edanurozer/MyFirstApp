using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş bırakmayınız");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage(" Yazar soy adını boş bırakmayınız");
            RuleFor(x => x.WriterAbaut).NotEmpty().WithMessage(" Hakkında kısmını boş bırakmayınız");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage(" Ünvan kısmını boş bırakmayınız");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Lütfen en 3 karakter girişi yapınız");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage(" Lütfen 50 karekterden fazla giriş yapmayınız");
        }
    }
}
