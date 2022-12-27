using GradingSystem.Application.Generic.Interfaces;
using GradingSystem.Application.List.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Interfaces
{
    public interface IListService : IBaseCrudService<Domain.Entities.List>
    {
        Task Put(ListDto dto);
        Task Push(int studentsId);
    }
}
