using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreDemo.Project.Entities.Concrete;
using FluentValidation;

namespace CoreDemo.Project.Business.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçmeyin");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori tanımlamasını boş geçmeyin");

        }
    }
}
