using CronBlocks.ACMEv2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core
{
    internal class AcmeProtocol
    {
        private readonly IAcmeLogging _log;
        private readonly CoreSettings _settings;

        public AcmeProtocol(IAcmeLogging logging, CoreSettings settings)
        {
            _log = logging ?? throw new ArgumentNullException(nameof(logging));
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }
    }
}
