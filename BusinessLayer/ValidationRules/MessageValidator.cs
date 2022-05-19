using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.RecieverMail).NotEmpty().WithMessage(" Alıcı Mail Adresini Boş geçemessiniz!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage(" Konuyu Boş geçemessiniz!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage(" Mesajı Boş geçemessiniz!");
            RuleFor(x => x.RecieverMail).EmailAddress().WithMessage("Geçerli bir mail adresi giriniz!");
            RuleFor(x => x.RecieverMail).MinimumLength(3).WithMessage("3 karakterden az değer girişi yapmayınız!");
            RuleFor(x => x.RecieverMail).MaximumLength(100).WithMessage("100 karakterden fazla değer girişi yapmayınız!");
        }
    }
}
