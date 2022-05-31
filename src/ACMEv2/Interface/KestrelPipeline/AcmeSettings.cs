using System;
using System.Collections.Generic;
using System.Text;

namespace CronBlocks.ACMEv2.Interface.KestrelPipeline
{
    public enum AcmeProvider
    {
        LetsEncrypt
    }

    public class AcmeSettings
    {
        public AcmeProvider AcmeProvider { get; set; } = AcmeProvider.LetsEncrypt;
        public bool UseStaging { get; set; } = true;
    }
}
