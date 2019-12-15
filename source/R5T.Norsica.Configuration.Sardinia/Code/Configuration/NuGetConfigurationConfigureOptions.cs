using System;

using Microsoft.Extensions.Options;

using RawNuGetConfiguration = R5T.Norsica.Configuration.Raw.NuGetConfiguration;


namespace R5T.Norsica.Configuration
{
    public class NuGetConfigurationConfigureOptions : IConfigureOptions<NuGetConfiguration>
    {
        private IOptions<RawNuGetConfiguration> RawNuGetConfiguration { get; set; }


        public NuGetConfigurationConfigureOptions(IOptions<RawNuGetConfiguration> rawNuGetConfiguration)
        {
            this.RawNuGetConfiguration = rawNuGetConfiguration;
        }

        public void Configure(NuGetConfiguration options)
        {
            var rawNuGetConfiguration = this.RawNuGetConfiguration.Value;

            options.NuGetExecutableFilePath = rawNuGetConfiguration.NuGetExecutableFilePath;
        }
    }
}
