using FluentValidation;
using GradingSystem.Application.Score.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Score.Validators
{
    public class ScoreValidator : AbstractValidator<ScoreDto>
    {
        public ScoreValidator()
        {
            RuleFor(x => x.SubjectId).NotEmpty().WithMessage("SubjectId is required");
            RuleFor(x => x.StudentsId).NotEmpty().WithMessage("StudentsId is required");
            RuleFor(x => x.rating).NotEmpty().WithMessage("Rating is required");
        }
    }
}
