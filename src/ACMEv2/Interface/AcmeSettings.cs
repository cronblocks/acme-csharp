using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CronBlocks.ACMEv2.Interface
{
    public enum AcmeProvider
    {
        LetsEncrypt
    }

    public class AcmeSettings
    {
        /// <summary>
        /// Directory where local ACME data is kept.
        /// </summary>
        public string LocalDataDir { get; set; } = $"{Path.Combine(Environment.CurrentDirectory, ".acme-data")}";

        /// <summary>
        /// Provider - default is Let's Encrypt
        /// </summary>
        public AcmeProvider AcmeProvider { get; set; } = AcmeProvider.LetsEncrypt;

        /// <summary>
        /// Whether or not to use staging server.
        /// </summary>
        public bool UseStaging { get; set; } = true;
    }
}
