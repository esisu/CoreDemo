using CoreDemo.Project.Entities.Concrete;
using FluentValidation;

namespace CoreDemo.Project.Business.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad Soyad boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz");
        }

    }
}
