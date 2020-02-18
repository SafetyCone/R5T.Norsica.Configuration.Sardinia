using System;

using Microsoft.Extensions.Options;

using RawDotnetConfiguration = R5T.Norsica.Configuration.Raw.DotnetConfiguration;


namespace R5T.Norsica.Configuration
{
    public class DotnetConfigurationConfigureOptions : IConfigureOptions<DotnetConfiguration>
    {
        private IOptions<RawDotnetConfiguration> RawNuGetConfiguration { get; }


        public DotnetConfigurationConfigureOptions(IOptions<RawDotnetConfiguration> rawNuGetConfiguration)
        {
            this.RawNuGetConfiguration = rawNuGetConfiguration;
        }

        public void Configure(DotnetConfiguration options)
        {
            var rawNuGetConfiguration = this.RawNuGetConfiguration.Value;

            options.DotnetExecutableFilePath = rawNuGetConfiguration.DotnetExecutableFilePath;
        }
    }
}
