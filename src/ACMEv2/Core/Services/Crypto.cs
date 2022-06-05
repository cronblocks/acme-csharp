using CronBlocks.ACMEv2.Interface;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Services
{
    internal class Crypto
    {
        private readonly ILogging _log;

        public Crypto(ILogging logging)
        {
            _log = logging;
        }
    }
}
