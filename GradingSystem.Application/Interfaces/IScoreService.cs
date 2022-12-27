using GradingSystem.Application.Generic.Interfaces;
using GradingSystem.Application.Score.Dto;
using GradingSystem.Application.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Interfaces
{
    public interface IScoreService : IBaseCrudService<Domain.Entities.Score>
    {
        Task Put(ScoreDto dto);
        Task Push(int studentsId);
    }
}
