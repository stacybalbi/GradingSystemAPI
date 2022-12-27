using AutoMapper;
using GradingSystem.Application.Generic.Handlers;
using GradingSystem.Application.Generic.Interfaces;
using GradingSystem.Application.Interfaces;
using GradingSystem.Application.List.Dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.List.Handlers
{

    public interface IListHandler : IBaseCrudHandler<ListDto, Domain.Entities.List>
    {
        new Task<ListDto> GetById(int id);
        new Task<ListDto> Update(ListDto dto);
        new Task<ListDto> Update(int id, ListDto dto);
        new Task<ListDto> Create(ListDto dto);
        new Task<List<ListDto>> Get(int top);
    }
    public class ListHandler : BaseCrudHandler<ListDto, Domain.Entities.List>, IListHandler
    {
        private readonly IListService _crudService;
        private readonly IMapper _mapper;

        public ListHandler(IListService crudService, IMapper mapper) : base(crudService, mapper)
        {
            _crudService = crudService;
            _mapper = mapper;
        }

        public new async Task<ListDto> GetById(int id)
        {
            var List = await base.GetById(id);

            if (List == null) throw new Exception("List not found");

            return List;

        }

        public new async Task<ListDto> Update(ListDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<ListDto> Update(int id, ListDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<ListDto> Create(ListDto dto)
        {

            return await base.Create(dto);

        }

        public async Task<List<ListDto>> Get(int top)
        {
            return _mapper.Map<List<ListDto>>(_crudService.Query().OrderBy(List => List.Created).ToList());
        }

    }

}
