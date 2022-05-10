using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş bırakılamaz!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklaması boş bırakılamaz!");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("20 karakterden fazla değer girişi yapmayınız!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("3 karakterden fazla değer girişi yapınız!");
        }

    }
}
