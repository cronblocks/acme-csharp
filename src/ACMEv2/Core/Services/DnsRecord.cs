using CronBlocks.ACMEv2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Services
{
    internal class DnsRecord
    {
        private readonly ILogging _log;

        public DnsRecord(ILogging logging)
        {
            _log = logging;
        }
    }
}
