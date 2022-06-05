using CronBlocks.ACMEv2.Core.Services;
using CronBlocks.ACMEv2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core
{
    internal class Protocol
    {
        private readonly ILogging _log;
        private readonly AcmeSettings _settings;

        public Protocol(AcmeSettings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));

            if (_settings.Logging == null)
            {
                _settings.Logging =
                    new ConsoleLogging(LoggingLevel.Info);
            }

            _log = _settings.Logging;

            _log.LogInfo($"Starting ACME Client: {DateTime.Now}");
        }
    }
}
