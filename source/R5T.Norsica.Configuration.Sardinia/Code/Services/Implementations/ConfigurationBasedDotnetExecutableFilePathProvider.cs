using System;

using Microsoft.Extensions.Options;


namespace R5T.Norsica.Configuration
{
    public class ConfigurationBasedDotnetExecutableFilePathProvider : IDotnetExecutableFilePathProvider
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
