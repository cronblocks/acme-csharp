using CronBlocks.ACMEv2.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Interface.KestrelPipeline
{
    public static class KestrelPipeline
    {
        private static AcmeSettings _settings;
        private static AcmeProtocol _protocol;

        public static void AddACMEv2(this IServiceCollection services, AcmeSettings acmeSettings = null)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            _settings = acmeSettings ?? new AcmeSettings();
            _settings.ServerType = ServerType.Kestrel;

            _protocol = new AcmeProtocol(_settings);
        }

        public static void UseACMEv2(this IApplicationBuilder appBuilder)
        {

        }
    }
}
