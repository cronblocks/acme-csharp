namespace CronBlocks.ACMEv2.Interface
{
    internal class AcmeDefaultConsoleLogging : IAcmeLogging
    {
        private readonly bool logInfo;
        private readonly bool logWarning;
        private readonly bool logError;

        public AcmeDefaultConsoleLogging(bool logInfo, bool logWarning, bool logError)
        {
            this.logInfo = logInfo;
            this.logWarning = logWarning;
            this.logError = logError;
        }

        public void LogError(string message)
        {
            if (logError)
            {
                System.Console.WriteLine($"ACME ERROR: {message}");
            }
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
    }
}