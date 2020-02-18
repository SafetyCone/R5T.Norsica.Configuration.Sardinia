using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using R5T.Dacia;
using R5T.Sardinia;

using RawNuGetConfiguration = R5T.Norsica.Configuration.Raw.DotnetConfiguration;


namespace R5T.Norsica.Configuration.Sardinia
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DotnetConfiguration"/> options service.
        /// </summary>
        public static IServiceCollection AddDotnetConfiguration(this IServiceCollection services)
        {
            services
                .AddOptions()
                .Configure<RawNuGetConfiguration>()
                .ConfigureOptions<DotnetConfigurationConfigureOptions>()
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DotnetConfiguration"/> options service.
        /// </summary>
        public static ServiceAction<IOptions<DotnetConfiguration>> AddDotnetConfigurationAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOptions<DotnetConfiguration>>(() => services.AddDotnetConfiguration());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConfigurationBasedDotnetExecutableFilePathProvider"/> implementation of <see cref="IDotnetExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConfigurationBasedDotnetExecutableFilePathProvider(this IServiceCollection services,
            ServiceAction<IOptions<DotnetConfiguration>> addDotnetConfiguration)
        {
            services
                .AddSingleton<IDotnetExecutableFilePathProvider, ConfigurationBasedDotnetExecutableFilePathProvider>()
                .RunServiceAction(addDotnetConfiguration)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConfigurationBasedDotnetExecutableFilePathProvider"/> implementation of <see cref="IDotnetExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IDotnetExecutableFilePathProvider> AddConfigurationBasedDotnetExecutableFilePathProviderAction(this IServiceCollection services,
            ServiceAction<IOptions<DotnetConfiguration>> addDotnetConfiguration)
        {
            var serviceAction = new ServiceAction<IDotnetExecutableFilePathProvider>(() => services.AddConfigurationBasedDotnetExecutableFilePathProvider(
                addDotnetConfiguration));
            return serviceAction;
        }
    }
}
