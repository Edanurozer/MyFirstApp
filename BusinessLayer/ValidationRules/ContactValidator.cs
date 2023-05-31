using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class ContactValidator :  AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Bırakmayınız");
            RuleFor(x => x.Subject).NotEmpty().WithMessage(" Konu Adını Boş Bıraknayınız");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Bırakmayınız");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Gişi Yapınız");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Gişi Yapınız");
            RuleFor(x => x.Subject).MinimumLength(50).WithMessage("Lütfen En Az 50 Karakter Gişi Yapınız");

        }
    }
}
