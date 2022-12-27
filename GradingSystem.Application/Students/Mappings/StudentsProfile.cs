using AutoMapper;
using GradingSystem.Application.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.Students.Mappings
{
    public class StudentsProfile : Profile
    {
        public StudentsProfile() 
        {
            CreateMap<Domain.Entities.Students, StudentsDto>();
            CreateMap<StudentsDto, Domain.Entities.Students>();
        }
    }
}
