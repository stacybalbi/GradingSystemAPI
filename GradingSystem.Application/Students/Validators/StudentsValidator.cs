using FluentValidation;
using GradingSystem.Application.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Students.Validators
{
    public class StudentsValidator : AbstractValidator<StudentsDto>
    {
        public StudentsValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}
