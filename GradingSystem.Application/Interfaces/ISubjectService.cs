using GradingSystem.Application.Generic.Interfaces;
using GradingSystem.Application.Subject.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Interfaces
{
    public interface ISubjectService : IBaseCrudService<Domain.Entities.Subject>
    {
        Task Put(SubjectDto dto);
        Task Push(int subjectId);

    }
}
