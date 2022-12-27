
using AutoMapper;
using GradingSystem.Application.Generic.Handlers;
using GradingSystem.Application.Generic.Interfaces;
using GradingSystem.Application.Interfaces;
using GradingSystem.Application.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Students.Handlers
{
   
        public interface IStudentsHandler : IBaseCrudHandler<StudentsDto, Domain.Entities.Students>
        {
            new Task<StudentsDto> GetById(int id);
            new Task<StudentsDto> Update(StudentsDto dto);
            new Task<StudentsDto> Update(int id, StudentsDto dto);
            new Task<StudentsDto> Create(StudentsDto dto);
            new Task<List<StudentsDto>> Get(int top);
        }
        public class StudentsHandler : BaseCrudHandler<StudentsDto, Domain.Entities.Students>, IStudentsHandler
        {
            private readonly IStudentsService _crudService;
            private readonly IMapper _mapper;

            public StudentsHandler(IStudentsService crudService, IMapper mapper) : base(crudService, mapper)
            {
                _crudService = crudService;
                _mapper = mapper;
            }

            public new async Task<StudentsDto> GetById(int id)
            {
                var Students = await base.GetById(id);

                if (Students == null) throw new Exception("Students not found");

                return Students;

            }

            public new async Task<StudentsDto> Update(StudentsDto dto)
            {
                return await base.Update(dto);
            }

            public new async Task<StudentsDto> Update(int id, StudentsDto dto)
            {
                return await base.Update(id, dto);
            }

            public new async Task<StudentsDto> Create(StudentsDto dto)
            {
                return await base.Create(dto);

            }

            public async Task<List<StudentsDto>> Get(int top)
            {
                return await base.Get(top);
            }

        }
  
}
