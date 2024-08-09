using Architecht.Application.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Validators
{
    public class RegisterUserValidator : AbstractValidator<RegisterUserDto>
    {
        public RegisterUserValidator()
        {
            RuleFor(x => x.EMail)
                .NotEmpty()
                .WithMessage("EMail is required!!")
                .EmailAddress()
                .WithMessage("EMail is not valid!!");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required!!")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,15}$")
                .WithMessage("Password must contain at least one uppercase letter, one lowercase letter, one number and one special character and must be between 8 and 15 characters long!!");

            //password check confirmPassword
            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .WithMessage("Password and ConfirmPassword must be the same!!");
        }
    }
}
