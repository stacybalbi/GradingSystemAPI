using GradingSystem.Application.Generic.Dto;
using GradingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Score.Dto
{
    public class ScoreDto : BaseDto
    {
        public int StudentsId { get; set; }

        public int SubjectId { get; set; }

        public int rating { get; set; }

        public Literals literals { get; set; }

    }
}
