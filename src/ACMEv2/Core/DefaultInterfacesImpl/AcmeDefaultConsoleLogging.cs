using CronBlocks.ACMEv2.Interface;

namespace CronBlocks.ACMEv2.Core.DefaultInterfacesImpl
{
    internal class AcmeDefaultConsoleLogging : IAcmeLogging
    {
        private readonly bool logInfo;
        private readonly bool logWarning;
        private readonly bool logError;

        public AcmeDefaultConsoleLogging(bool logInfo = false, bool logWarning = true, bool logError = true)
        {
            this.logInfo = logInfo;
            this.logWarning = logWarning;
            this.logError = logError;
        }

        public void LogInfo(string message)
        {
            if (logInfo)
            {
                System.Console.WriteLine($"ACME: {message}");
            }
        }

        public void LogWarning(string message)
        {
            if (logWarning)
            {
                System.Console.WriteLine($"ACME Warning: {message}");
            }
        }

        public void LogError(string message)
        {
            if (logError)
            {
                System.Console.WriteLine($"ACME ERROR: {message}");
            }
        }
    }
}