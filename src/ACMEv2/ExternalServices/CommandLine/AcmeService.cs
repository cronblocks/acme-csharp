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
        }
    }
}
