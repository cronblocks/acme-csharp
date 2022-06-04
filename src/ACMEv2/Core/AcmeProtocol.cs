using CronBlocks.ACMEv2.Core.Handlers;
using CronBlocks.ACMEv2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core
{
    internal class AcmeProtocol
    {
        private readonly IAcmeLogging _log;
        private readonly AcmeSettings _settings;

        public AcmeProtocol(AcmeSettings settings)
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
