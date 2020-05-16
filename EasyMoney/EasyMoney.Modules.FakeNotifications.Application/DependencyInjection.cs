﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EasyMoney.Modules.FakeNotifications.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddFakeNotificationApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
