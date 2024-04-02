using CleanArchiteture.Application.Interfaces;
using CleanArchiteture.Application.Services;
using CleanArchiteture.Domain.Interfaces;
using CleanArchiteture.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchiteture.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();


            //Infra.Dat Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
