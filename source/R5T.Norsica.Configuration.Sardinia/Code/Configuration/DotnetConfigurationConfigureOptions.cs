using System;

using Microsoft.Extensions.Options;

using RawNuGetConfiguration = R5T.Norsica.Configuration.Raw.DotnetConfiguration;


namespace R5T.Norsica.Configuration
{
    public class DotnetConfigurationConfigureOptions : IConfigureOptions<DotnetConfiguration>
    {
        private IOptions<RawNuGetConfiguration> RawNuGetConfiguration { get; }


        public DotnetConfigurationConfigureOptions(IOptions<RawNuGetConfiguration> rawNuGetConfiguration)
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
