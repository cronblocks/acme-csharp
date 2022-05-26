using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.ExternalServices.CommandLine
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

        public void GetCertificate(
            Action<string> failureCallback = null,
            Action<string> successCallback = null)
        {
            throw new NotImplementedException();
        }
    }
}
