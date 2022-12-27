using AutoMapper;
using GradingSystem.Application.Interfaces;
using GradingSystem.Application.Subject.Dto;
using GradingSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Infrastructure.Services
{
        public class SubjectService : BaseCrudService<Domain.Entities.Subject>, ISubjectService
        {
            private readonly IMapper _mapper;
            public IGradingSystemDbContext _dbContext;
            public SubjectService(IGradingSystemDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
            {
                _mapper = mapper;
                _dbContext = dbContext;
            }


            public Task Push(int subjectId)
            {
                _dbContext.SaveChanges();
                return Task.CompletedTask;
            }

            public async Task Put(SubjectDto dto)
            {
                await _dbSet.AddAsync(_mapper.Map<Domain.Entities.Subject>(dto));
                _dbContext.SaveChanges();
            }

        }
    
}
