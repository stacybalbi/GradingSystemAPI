using FluentValidation;
using GradingSystem.Application.Subject.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Subject.Validators
{
    public class SubjectValidator : AbstractValidator<SubjectDto>
    {
        public SubjectValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}
