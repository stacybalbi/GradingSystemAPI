using AutoMapper;
using GradingSystem.Application.Interfaces;
using GradingSystem.Application.DayList.Dto;
using GradingSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Infrastructure.Services
{
    public class DayListService : BaseCrudService<Domain.Entities.DayList>, IDayListService
    {
        private readonly IMapper _mapper;
        public IGradingSystemDbContext _dbContext;
        public DayListService(IGradingSystemDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }


        public Task Push(int queueId)
        {
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task Put(DayListDto dto)
        {
            await _dbSet.AddAsync(_mapper.Map<Domain.Entities.DayList>(dto));
            _dbContext.SaveChanges();
        }

    }
}
