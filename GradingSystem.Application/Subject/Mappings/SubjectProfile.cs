using AutoMapper;
using GradingSystem.Application.Subject.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Subject.Mappings
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<Domain.Entities.Subject, SubjectDto>();
            CreateMap<SubjectDto, Domain.Entities.Subject>();
        }
    }
}
