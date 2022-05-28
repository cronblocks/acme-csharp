using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Interface.CommandLine
{
    public class AcmeService
    {
        public AcmeSettings AcmeSettings { get; }

        public AcmeService(AcmeSettings acmeSettings = null)
        {
            AcmeSettings = acmeSettings;

            if (AcmeSettings == null)
            {
                AcmeSettings = new AcmeSettings()
                {
                    // Default settings' overrides here
                };
            }
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
