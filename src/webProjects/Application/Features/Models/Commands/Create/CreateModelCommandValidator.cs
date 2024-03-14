using Application.Features.Models.Constants;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Commands.Create
{
    public class CreateModelCommandValidator : AbstractValidator<CreateModelCommand>
    {
        public CreateModelCommandValidator()
        {
            RuleFor(b => b.Name).NotEmpty().WithMessage(ModelValidatorMessages.NameNotBlank);
            RuleFor(b => b.Name).Length(3);
        }
    }
}
