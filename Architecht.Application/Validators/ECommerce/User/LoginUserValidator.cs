using Architecht.Application.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Validators
{
    public class LoginUserValidator : AbstractValidator<LoginUserDto>
    {

        public LoginUserValidator()
        {
            RuleFor(x => x.EMail)
                .NotEmpty()
                .WithMessage("EMail is required")
                .EmailAddress()
                .WithMessage("EMail is not valid");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required");
        }

    }
}
