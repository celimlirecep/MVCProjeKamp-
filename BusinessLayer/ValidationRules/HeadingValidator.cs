using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HeadingValidator:AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Yazar adı boş bırakılamaz!");
            RuleFor(x => x.WriterId).NotEmpty().WithMessage("Yazar soyadı açıklaması boş bırakılamaz!");

           
            

            RuleFor(x => x.HeadingName).MaximumLength(50).WithMessage("50 karakterden fazla değer girişi yapmayınız!");
            RuleFor(x => x.HeadingName).MinimumLength(2).WithMessage("2 karakterden fazla değer girişi yapınız!");
        }
      
    }
}
