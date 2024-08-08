using Architecht.Application.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Validators
{
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryDto>
    {

        public CreateCategoryValidator()
        {
             RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required!!");
        }

    }
}
