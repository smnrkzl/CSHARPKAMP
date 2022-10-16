using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
           
            RuleFor(u => u.Password).NotEmpty().WithMessage("Lütfen parola giriniz");
            RuleFor(u => u.Password).MinimumLength(8).WithMessage("Parola en az 8 karakterden oluşmalıdır.");
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Lütfen isim giriniz");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Lütfen soyisim giriniz");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Lütfen Email giriniz");

        }
    }
}
