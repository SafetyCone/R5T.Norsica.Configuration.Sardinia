using System;

using Microsoft.Extensions.Options;


namespace R5T.Norsica.Configuration
{
    public class ConfigurationBasedNuGetExecutableFilePathProvider : INugetExecutableFilePathProvider
    {
        private IOptions<NuGetConfiguration> NuGetConfiguration { get; }


        public ConfigurationBasedNuGetExecutableFilePathProvider(IOptions<NuGetConfiguration> nuGetConfiguration)
        {
            this.NuGetConfiguration = nuGetConfiguration;
        }

        public string GetNugetExecutableFilePath()
        {
            var nuGetConfiguration = this.NuGetConfiguration.Value;

            var nugetExecutableFilePath = nuGetConfiguration.NuGetExecutableFilePath;
            return nugetExecutableFilePath;
        }
    }
}
