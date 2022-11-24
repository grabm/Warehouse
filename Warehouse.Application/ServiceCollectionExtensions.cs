﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Application
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication (this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetAssembly(typeof(ServiceCollectionExtensions)));
            services.AddMediatR(Assembly.GetAssembly(typeof(ServiceCollectionExtensions)));
        }
    }
}