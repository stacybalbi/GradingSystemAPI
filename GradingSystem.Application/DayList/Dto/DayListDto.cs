using GradingSystem.Application.Generic.Dto;
using GradingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.DayList.Dto
{
    public class DayListDto : BaseDto
    {
        public int StudentsId { get; set; }

        public Assistance assistance { get; set; }
    }
}
