using Microsoft.Extensions.DependencyInjection;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Repositories;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Services;
using ProjectOnion.Core.Aggregate.OnionAgg.Services;
using ProjectOnion.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOnion.CrossCutting
{
    public static class Injector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICategoryAndCourseService, CategoryAndCourseService>();

            
            services.AddScoped<ICategory, CategoryRepository>();
            services.AddScoped<ICourse, CourseRepository>();
            services.AddScoped<ICategoryAndCourse, CategoryAndCourseRepository>();


        }
    }
}
