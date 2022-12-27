using AutoMapper;
using GradingSystem.Application.Interfaces;
using GradingSystem.Application.Score.Dto;
using GradingSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Infrastructure.Services
{
    public class ScoreService : BaseCrudService<Domain.Entities.Score>, IScoreService
    {
        private readonly IMapper _mapper;
        public IGradingSystemDbContext _dbContext;
        public ScoreService(IGradingSystemDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }


        public Task Push(int queueId)
        {
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task Put(ScoreDto dto)
        {
            await _dbSet.AddAsync(_mapper.Map<Domain.Entities.Score>(dto));
            _dbContext.SaveChanges();
        }

    }
}
