using AutoMapper;
using GradingSystem.Application.DayList.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.DayList.Mappings
{
    public class DayListProfile : Profile
    {
        public DayListProfile()
        {
            CreateMap<Domain.Entities.DayList, DayListDto>();
            CreateMap<DayListDto, Domain.Entities.DayList>();
        }
    }
}
