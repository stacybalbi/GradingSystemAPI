using AutoMapper;
using GradingSystem.Application.Generic.Handlers;
using GradingSystem.Application.Generic.Interfaces;
using GradingSystem.Application.Interfaces;
using GradingSystem.Application.DayList.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradingSystem.Domain.Enums;

namespace GradingSystem.Application.DayList.Handlers
{

    public interface IDayListHandler : IBaseCrudHandler<DayListDto, Domain.Entities.DayList>
    {
        new Task<DayListDto> GetById(int id);
        new Task<DayListDto> Update(DayListDto dto);
        new Task<DayListDto> Update(int id, DayListDto dto);
        new Task<DayListDto> Create(DayListDto dto);
        new Task<List<DayListDto>> Get(int top);
    }
    public class DayListHandler : BaseCrudHandler<DayListDto, Domain.Entities.DayList>, IDayListHandler
    {
        private readonly IDayListService _crudService;
        private readonly IMapper _mapper;

        public DayListHandler(IDayListService crudService, IMapper mapper) : base(crudService, mapper)
        {
            _crudService = crudService;
            _mapper = mapper;
        }

        public new async Task<DayListDto> GetById(int id)
        {
            var DayList = await base.GetById(id);

            if (DayList == null) throw new Exception("DayList not found");

            return DayList;

        }

        public new async Task<DayListDto> Update(DayListDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<DayListDto> Update(int id, DayListDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<DayListDto> Create(DayListDto dto)
        {
            return await base.Create(dto);

        }

        public async Task<List<DayListDto>> Get(int top)
        {
            return await base.Get(top);
        }

    }

}
