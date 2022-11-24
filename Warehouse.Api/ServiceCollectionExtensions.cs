﻿using Microsoft.Extensions.DependencyInjection;

namespace Warehouse.Api
{
    public static class ServiceCollectionExtensions
    {
        public static void AddWeather(this IServiceCollection services)
        {
            services.AddTransient<WeatherForecastService>();
            services.AddTransient<WeatherForecastService>();
            services.AddTransient<WeatherForecastService>();
            services.AddTransient<WeatherForecastService>();
        }
    }
}
