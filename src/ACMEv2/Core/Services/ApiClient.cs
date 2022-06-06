using CronBlocks.ACMEv2.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CronBlocks.ACMEv2.Core.Services
{
    internal class ApiClient
    {
        private readonly ILogging _log;
        private HttpClient _http;

        public ApiClient(ILogging logging)
        {
            _log = logging;
            _http = new HttpClient();
        }
    }
}
