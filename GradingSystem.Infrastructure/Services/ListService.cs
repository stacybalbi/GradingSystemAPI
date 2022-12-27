using AutoMapper;
using GradingSystem.Application.Interfaces;
using GradingSystem.Application.List.Dto;
using GradingSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Infrastructure.Services
{
    public class ListService : BaseCrudService<Domain.Entities.List>, IListService
    {
        private readonly IMapper _mapper;
        public IGradingSystemDbContext _dbContext;
        public ListService(IGradingSystemDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }


        public Task Push(int queueId)
        {
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task Put(ListDto dto)
        {
            await _dbSet.AddAsync(_mapper.Map<Domain.Entities.List>(dto));
            _dbContext.SaveChanges();
        }

    }
}
