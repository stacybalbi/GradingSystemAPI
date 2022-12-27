using AutoMapper;
using GradingSystem.Application.List.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.List.Mappings
{
    public class ListProfile : Profile
    {
        public ListProfile()
        {
            CreateMap<Domain.Entities.List, ListDto>();
            CreateMap<ListDto, Domain.Entities.List>();
        }
    }
}
