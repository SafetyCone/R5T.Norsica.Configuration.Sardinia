using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Sardinia;

using RawNuGetConfiguration = R5T.Norsica.Configuration.Raw.DotnetConfiguration;


namespace R5T.Norsica.Configuration.Sardinia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDotnetConfiguration(this IServiceCollection services)
        {
            services
                .Configure<RawNuGetConfiguration>()
                .ConfigureOptions<DotnetConfigurationConfigureOptions>()
                ;

            return services;
        }
    }
}
