using CronBlocks.ACMEv2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Services
{
    internal class Accounts
    {
        private readonly ILogging _log;

        public Accounts(ILogging logging)
        {
            _log = logging;
        }
    }
}
