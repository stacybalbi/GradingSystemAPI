using AutoMapper;
using GradingSystem.Application.Score.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Score.Mappings
{
    public class ScoreProfile : Profile
    {
        public ScoreProfile()
        {
            CreateMap<Domain.Entities.Score, ScoreDto>();
            CreateMap<ScoreDto, Domain.Entities.Score>();
        }
    }
}
