using FluentValidation;
using GradingSystem.Application.DayList.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.DayList.Validators
{
    public class DayListValidator : AbstractValidator<DayListDto>
    {
        public DayListValidator()
        {
            RuleFor(x => x.StudentsId).NotEmpty().WithMessage("StudentId is required");
            RuleFor(x => x.assistance).NotEmpty().WithMessage("Assistance is required");
        }
    }
}
