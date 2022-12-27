using AutoMapper;
using GradingSystem.Application.Generic.Handlers;
using GradingSystem.Application.Generic.Interfaces;
using GradingSystem.Application.Interfaces;
using GradingSystem.Application.Subject.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Subject.Handlers
{

    public interface ISubjectHandler : IBaseCrudHandler<SubjectDto, Domain.Entities.Subject>
    {
        new Task<SubjectDto> GetById(int id);
        new Task<SubjectDto> Update(SubjectDto dto);
        new Task<SubjectDto> Update(int id, SubjectDto dto);
        new Task<SubjectDto> Create(SubjectDto dto);
        new Task<List<SubjectDto>> Get(int top);
    }
    public class SubjectHandler : BaseCrudHandler<SubjectDto, Domain.Entities.Subject>, ISubjectHandler
    {
        private readonly ISubjectService _crudService;
        private readonly IMapper _mapper;

        public SubjectHandler(ISubjectService crudService, IMapper mapper) : base(crudService, mapper)
        {
            _crudService = crudService;
            _mapper = mapper;
        }

        public new async Task<SubjectDto> GetById(int id)
        {
            var Subject = await base.GetById(id);

            if (Subject == null) throw new Exception("Subject not found");

            return Subject;

        }

        public new async Task<SubjectDto> Update(SubjectDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<SubjectDto> Update(int id, SubjectDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<SubjectDto> Create(SubjectDto dto)
        {
            return await base.Create(dto);

        }

        public async Task<List<SubjectDto>> Get(int top)
        {
            return await base.Get(top);
        }

    }
}
