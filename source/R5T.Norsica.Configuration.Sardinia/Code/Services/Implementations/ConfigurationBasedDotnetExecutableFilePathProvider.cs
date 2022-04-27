using System;

using Microsoft.Extensions.Options;using R5T.T0064;


namespace R5T.Norsica.Configuration
{[ServiceImplementationMarker]
    public class ConfigurationBasedDotnetExecutableFilePathProvider : IDotnetExecutableFilePathProvider,IServiceImplementation
    {
        private IOptions<DotnetConfiguration> DotnetConfiguration { get; }


        public ConfigurationBasedDotnetExecutableFilePathProvider(IOptions<DotnetConfiguration> dotnetConfiguration)
        {
            this.DotnetConfiguration = dotnetConfiguration;
        }

        public string GetDotnetExecutableFilePath()
        {
            var dotnetConfiguration = this.DotnetConfiguration.Value;

            var dotnetExecutableFilePath = dotnetConfiguration.DotnetExecutableFilePath;
            return dotnetExecutableFilePath;
        }
    }
}
