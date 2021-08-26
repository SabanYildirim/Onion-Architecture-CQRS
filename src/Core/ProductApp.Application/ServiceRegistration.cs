using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ProductApp.Application
{
    public static class ServiceRegistration 
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assm);
            services.AddMediatR(assm);
        }
    }
}
