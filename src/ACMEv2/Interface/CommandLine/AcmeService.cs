using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Interface.CommandLine
{
    public class AcmeService
    {
        private AcmeSettings _settings;

        public AcmeService(AcmeSettings acmeSettings = null)
        {
            _settings = acmeSettings ?? new AcmeSettings();
            _settings.ServerType = ServerType.TempServer;
        }

        /// <summary>
        /// Runs ACME client procedure
        /// </summary>
        /// <param name="failureCallback">Callback function that is called with failure message as it's input</param>
        /// <param name="successCallback">Callback function that is called upon success with message and certificate file name as its input</param>
        /// <exception cref="NotImplementedException"></exception>
        public void GetCertificate(Action<string> failureCallback = null,
                                   Action<string, string> successCallback = null)
        {
            throw new NotImplementedException();
        }
    }
}
