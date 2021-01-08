﻿using Microsoft.Extensions.DependencyInjection;
using System;

namespace BlazorPro.BlazorSize
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a BlazorSize.ResizeListener as a Scoped instance.
        /// </summary>
        /// <param name="configure">Defines settings for this instance.</param>
        /// <returns>Continues the IServiceCollection chain.</returns>
        public static IServiceCollection AddResizeListener(this IServiceCollection services,
            Action<ResizeOptions> configure)
        {
            services.AddScoped<ResizeListener>();
            services.Configure(configure);
            return services;
        }

        /// <summary>
        /// Adds a BlazorSize.MediaQueryService as a Scoped instance.
        /// </summary>
        /// <returns>Continues the IServiceCollection chain.</returns>
        public static IServiceCollection AddMediaQueryService(this IServiceCollection services)
        {
            services.AddScoped<IMediaQueryService, MediaQueryService>();
            return services;
        }

    }
}