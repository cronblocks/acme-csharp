using CronBlocks.ACMEv2.Interface;
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Services
{
    internal class ApiClient
    {
        private readonly ILogging _log;

        public ApiClient(ILogging logging)
        {
            _log = logging;
    }
}
}
