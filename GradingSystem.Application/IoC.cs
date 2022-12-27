using FluentValidation;
using GradingSystem.Application.DayList.Handlers;
using GradingSystem.Application.List.Handlers;
using GradingSystem.Application.Score.Handlers;
using GradingSystem.Application.Students.Handlers;
using GradingSystem.Application.Subject.Handlers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application
{
    public static class IoC
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IScoreHandler, ScoreHandler>();
            services.AddTransient<IStudentsHandler, StudentsHandler>();
            services.AddTransient<ISubjectHandler, SubjectHandler>();
            services.AddTransient<IListHandler, ListHandler>();
            services.AddTransient<IDayListHandler, DayListHandler>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
