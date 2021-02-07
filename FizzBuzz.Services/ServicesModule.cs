using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzz.Services.Interfaces;
using FizzBuzz.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz.Services
{
    public static class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IFizzBuzzService, FizzBuzzService>();
            
        }
    }
}
