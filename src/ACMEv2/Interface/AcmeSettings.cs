using System;
using System.IO;

namespace CronBlocks.ACMEv2.Interface
{
    public enum AcmeProvider
    {
        LetsEncrypt
    }

    public class AcmeSettings
    {
        /// <summary>
        /// Location for keeping local ACME data - default = {current-directory}/.acme-data
        /// </summary>
        public string LocalDataDir { get; set; } = $"{Path.Combine(Environment.CurrentDirectory, ".acme-data")}";

        /// <summary>
        /// Certificate provider - default = Let's Encrypt
        /// </summary>
        public AcmeProvider AcmeProvider { get; set; } = AcmeProvider.LetsEncrypt;

        /// <summary>
        /// Whether or not to use staging server - default = true
        /// </summary>
        public bool UseStaging { get; set; } = true;
    }
}
