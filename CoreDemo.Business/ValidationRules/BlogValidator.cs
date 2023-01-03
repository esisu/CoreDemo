using CoreDemo.Project.Entities.Concrete;
using FluentValidation;

namespace CoreDemo.Project.Business.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Lütfen Boş Geçmeyiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Lütfen Boş Geçmeyiniz");
            //RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Lütfen Boş Geçmeyiniz");
            //RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("150 Karakter Maksimüm Limit");
        }
    }
}
