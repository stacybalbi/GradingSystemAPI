using FluentValidation;
using GradingSystem.Application.List.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.List.Validators
{
    public class ListValidator : AbstractValidator<ListDto>
    {
        public ListValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.daylistId).NotEmpty().WithMessage("daylistId is required");
            RuleFor(x => x.Created).NotEmpty().WithMessage("Created is required");
        }
    }
}
