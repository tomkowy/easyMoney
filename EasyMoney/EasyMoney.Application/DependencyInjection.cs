﻿using EasyMoney.Fake;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EasyMoney.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IFakeService, FakeService>();
            return services;
        }
    }
}
