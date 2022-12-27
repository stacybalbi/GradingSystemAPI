using AutoMapper;
using GradingSystem.Application.Interfaces;
using GradingSystem.Application.Students.Dto;
using GradingSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Infrastructure.Services
{
    public class StudentsService : BaseCrudService<Domain.Entities.Students>, IStudentsService
    {
        private readonly IMapper _mapper;
        public IGradingSystemDbContext _dbContext;
        public StudentsService(IGradingSystemDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }


        public Task Push(int studentId)
        {
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task Put(StudentsDto dto)
        {
            await _dbSet.AddAsync(_mapper.Map<Domain.Entities.Students>(dto));
            _dbContext.SaveChanges();
        }

    }
}
