using AutoMapper;
using GradingSystem.Application.Generic.Handlers;
using GradingSystem.Application.Generic.Interfaces;
using GradingSystem.Application.Interfaces;
using GradingSystem.Application.Score.Dto;
using GradingSystem.Domain.Entities;
using GradingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Score.Handlers
{

    public interface IScoreHandler : IBaseCrudHandler<ScoreDto, Domain.Entities.Score>
    {
        new Task<ScoreDto> GetById(int id);
        new Task<ScoreDto> Update(ScoreDto dto);
        new Task<ScoreDto> Update(int id, ScoreDto dto);
        new Task<ScoreDto> Create(ScoreDto dto);
        new Task<List<ScoreDto>> Get(int top);
    }
    public class ScoreHandler : BaseCrudHandler<ScoreDto, Domain.Entities.Score>, IScoreHandler
    {
        private readonly IScoreService _crudService;
        private readonly IMapper _mapper;

        public ScoreHandler(IScoreService crudService, IMapper mapper) : base(crudService, mapper)
        {
            _crudService = crudService;
            _mapper = mapper;
        }

        public new async Task<ScoreDto> GetById(int id)
        {
            var Score = await base.GetById(id);

            if (Score == null) throw new Exception("Score not found");

            return Score;

        }

        public new async Task<ScoreDto> Update(ScoreDto dto)
        {
            var rating = dto.rating;
            if (rating >= 90) { dto.literals = Literals.A; }
            else if (rating >= 80 && rating <= 89) { dto.literals = Literals.B; }
            else if (rating >= 70 && rating <= 79) { dto.literals = Literals.C; }
            else { dto.literals = Literals.F; }

            return await base.Update(dto);
        }

        public new async Task<ScoreDto> Update(int id, ScoreDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<ScoreDto> Create(ScoreDto dto)
        {
            var rating = dto.rating;
            if (rating >= 90) { dto.literals = Literals.A; }
            else if (rating >= 80 && rating <= 89) { dto.literals = Literals.B; }
            else if (rating >= 70 && rating <= 79) { dto.literals = Literals.C; }
            else { dto.literals = Literals.F; }


            return await base.Create(dto);

        }

        public async Task<List<ScoreDto>> Get(int top)
        {
            return await base.Get(top);
        }

    }
}
