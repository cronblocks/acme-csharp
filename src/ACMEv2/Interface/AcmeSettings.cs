using CronBlocks.ACMEv2.Core.DefaultInterfacesImpl;
using System;
using System.IO;

namespace CronBlocks.ACMEv2.Interface
{
    public enum AcmeProvider
    {
        LetsEncrypt
    }

    public enum ValidationMethod
    {
        HttpQuery,
        DnsTxtRecord
    }

    public enum ServerType
    {
        None,
        TempServer,
        Kestrel
    }

    public class AcmeSettings
    {
        /// <summary>
        /// Logging ACME messages - default = ConsoleLogging
        /// </summary>
        public IAcmeLogging Logging { get; set; } = new ConsoleLogging(LoggingLevel.Info);

        /// <summary>
        /// Location for keeping local ACME data - default = {current-directory}/.acme-data
        /// </summary>
        public string LocalDataDir { get; set; } = $"{Path.Combine(Environment.CurrentDirectory, ".acme-data")}";

        /// <summary>
        /// Certificate provider - default = Let's Encrypt
        /// </summary>
        public AcmeProvider AcmeProvider { get; set; } = AcmeProvider.LetsEncrypt;

        /// <summary>
        /// Whether or not to use staging environment - default = true
        /// </summary>
        public bool UseStaging { get; set; } = true;

        /// <summary>
        /// Domain control validation method - default = HTTP Request Validation
        /// </summary>
        public ValidationMethod ValidationMethod { get; set; } = ValidationMethod.HttpQuery;

        /// <summary>
        /// Server type - default = None
        /// </summary>
        public ServerType ServerType { get; set; } = ServerType.None;
    }
}
