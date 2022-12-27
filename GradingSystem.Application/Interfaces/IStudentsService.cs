using GradingSystem.Application.Generic.Interfaces;
using GradingSystem.Application.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Interfaces
{
    public interface IStudentsService : IBaseCrudService<Domain.Entities.Students>
    {
        Task Put(StudentsDto dto);
        Task Push(int studentsId);
    }
}
