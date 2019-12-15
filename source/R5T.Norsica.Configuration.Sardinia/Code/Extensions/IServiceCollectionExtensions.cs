using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Sardinia;

using RawNuGetConfiguration = R5T.Norsica.Configuration.Raw.NuGetConfiguration;


namespace R5T.Norsica.Configuration.Sardinia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddNuGetConfiguration(this IServiceCollection services)
        {
            services
                .Configure<RawNuGetConfiguration>()
                .ConfigureOptions<NuGetConfigurationConfigureOptions>()
                ;

            return services;
        }
    }
}
