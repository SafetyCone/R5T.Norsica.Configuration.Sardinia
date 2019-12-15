using System;

using Microsoft.Extensions.Options;


namespace R5T.Norsica.Configuration
{
    public class ConfigurationBasedDotnetExecutableFilePathProvider : IDotnetExecutableFilePathProvider
    {
        private IOptions<DotnetConfiguration> NuGetConfiguration { get; }


        public ConfigurationBasedDotnetExecutableFilePathProvider(IOptions<DotnetConfiguration> nuGetConfiguration)
        {
            this.NuGetConfiguration = nuGetConfiguration;
        }

        public string GetDotnetExecutableFilePath()
        {
            var nuGetConfiguration = this.NuGetConfiguration.Value;

            var nugetExecutableFilePath = nuGetConfiguration.NuGetExecutableFilePath;
            return nugetExecutableFilePath;
        }
    }
}
