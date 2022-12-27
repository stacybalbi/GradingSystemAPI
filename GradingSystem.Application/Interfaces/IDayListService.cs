using GradingSystem.Application.Generic.Interfaces;
using GradingSystem.Application.DayList.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Interfaces
{
    public interface IDayListService : IBaseCrudService<Domain.Entities.DayList>
    {
        Task Put(DayListDto dto);
        Task Push(int studentsId);
    }
}
