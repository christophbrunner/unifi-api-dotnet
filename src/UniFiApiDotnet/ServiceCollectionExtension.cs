using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection UseUniFiApiDotnet(this IServiceCollection services)
        {
            return UseUniFiApiDotnet(services, builder => { });
        }

        public static IServiceCollection UseUniFiApiDotnet(this IServiceCollection services,
            Action<IUniFiApiBuilder> configure)
        {
            IUniFiApiBuilder builder = new UniFiApiBuilder();

            configure(builder);

            UniFiApiService.ApiKey = builder.ApiKey;

            if (builder.UserAgent != string.Empty)
            {
                UniFiApiService.UserAgent = builder.UserAgent;
            }

            if (builder.ConfigSectionName != string.Empty)
            {
                UniFiApiService.ConfigSectionName = builder.ConfigSectionName;
            }

            if (builder.HttpClientFactoryClientName != string.Empty)
            {
                UniFiApiService.HttpClientFactoryClientName = builder.HttpClientFactoryClientName;
            }

            services.AddSingleton<IUniFiApiService>(sp =>
            {
                IServiceProvider serviceProvider = sp.GetRequiredService<IServiceProvider>();
                ILogger<UniFiApiService> logger = sp.GetRequiredService<ILogger<UniFiApiService>>();
                IConfiguration configuration = sp.GetRequiredService<IConfiguration>();

                return ActivatorUtilities.CreateInstance<UniFiApiService>(sp, serviceProvider, logger, configuration);
            });

            return services;
        }
    }
}