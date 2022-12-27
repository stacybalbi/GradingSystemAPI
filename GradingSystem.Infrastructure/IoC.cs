using GradingSystem.Application.Interfaces;
using GradingSystem.Infrastructure.Context;
using GradingSystem.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient<IScoreService, ScoreService>();
            services.AddTransient<IStudentsService, StudentsService>();
            services.AddTransient<ISubjectService, SubjectService>();
            services.AddTransient<IListService, ListService>();
            services.AddTransient<IDayListService, DayListService>();
            services.AddTransient<IGradingSystemDbContext, GradingSystemDbContext>();


            services.AddDbContext<GradingSystemDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("GradingSystemdb")));

            return services;


        }
    }
}
